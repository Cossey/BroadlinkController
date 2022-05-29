﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SharpBroadlink.Devices
{
    /// <summary>
    /// Rm - Programmable Remote Controller for IR
    /// </summary>
    /// <remarks>
    /// https://github.com/mjg59/python-broadlink/blob/56b2ac36e5a2359272f4af8a49cfaf3e1891733a/broadlink/__init__.py#L524-L559
    /// </remarks>
    public class Rm : Device
    {
        #region Properties

        public bool SixBytePreamble = false;
        public static TimeSpan IRLearnIterval { get; set; } = TimeSpan.FromMilliseconds(100);

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="host"></param>
        /// <param name="mac"></param>
        /// <param name="devType"></param>
        public Rm(IPEndPoint host, byte[] mac, int devType) : base(host, mac, devType)
        {
            DeviceType = DeviceType.Rm;
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Into IR Learning mode
        /// </summary>
        /// <returns></returns>
        public async Task<bool> EnterLearning()
        {
            var packet = new byte[16];            
            packet[0] = 0x03;

            await SendPacket(0x6a, processPayload(packet));

            return true;
        }

        private byte[] processPayload(byte[] payload)
        {
            if (SixBytePreamble)
            {
                int length = payload.Length + 4;
                List<byte> pl = payload.ToList();
                List<byte> b2 = new List<byte> { (byte)(length & 0xFF), (byte)((length >> 8) & 0xFF) };
                pl.InsertRange(0, b2);

                //byte[] preamble = new byte[6];
                //int length = payload.Length + 4;
                //preamble[0] = (byte)(length & 0xFF);
                //preamble[1] = (byte)((length >> 8) & 0xFF);
                //preamble[2] = payload[0];
                //preamble.CopyTo(payload, 0);
                payload = pl.ToArray();
            }

            return payload;
        }

        /// <summary>
        /// Check recieved IR signal-data
        /// </summary>
        /// <returns></returns>
        public async Task<byte[]> CheckData()
        {
            var packet = new byte[16];
            packet[0] = 0x04;

            var response = await SendPacket(0x6a, processPayload(packet));
            if (response == null || response.Length <= 0x38)
                return null;

            var err = response[0x22] | (response[0x23] << 8);
            if (err == 0)
            {
                var payload = Decrypt(response, 0x38);
                if (payload.Length <= 0x04)
                    return null;
                int index = 0x04;
                if (SixBytePreamble) index = 0x06;
                return payload.Skip(index).Take(int.MaxValue).ToArray();
            }

            // failure
            return null;
        }

        /// <summary>
        /// Cancel IR Learning mode
        /// </summary>
        /// <returns></returns>
        public async Task<bool> CancelLearning()
        {
            var packet = new byte[16];
            packet[0] = 0x1e;

            await SendPacket(0x6a, processPayload(packet));

            return true;
        }

        /// <summary>
        /// Send IR signal-data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<bool> SendData(byte[] data)
        {
            var packet = new List<byte>();
            //if (SixBytePreamble)
            //{
            //    byte[] preamble = new byte[6];
            //    int length = data.Length + 4;
            //    preamble[0] = (byte)(length & 0xFF);
            //    preamble[1] = (byte)((length >> 8) & 0xFF);
            //    preamble[2] = 0x02;
            //    packet.AddRange(preamble);
            //} else
            //{
                packet.AddRange(new byte[] { 0x02, 0x00, 0x00, 0x00});
            //}
            packet.AddRange(data);

            await SendPacket(0x6a, processPayload(packet.ToArray()));

            return true;
        }

        /// <summary>
        /// Get temperature
        /// </summary>
        /// <returns></returns>
        public async Task<double> CheckTemperature()
        {
            double temp = double.MinValue;
            var packet = new byte[16];
            packet[0] = 1;

            var response = await SendPacket(0x6a, processPayload(packet));
            var err = response[0x22] | (response[0x23] << 8);

            if (err == 0)
            {
                var payload = Decrypt(response, 0x38);
                var charInt = ((char)packet[0x4]).ToString();
                var tmpInt = 0;
                if (int.TryParse(charInt, out tmpInt))
                {
                    // character returned
                    temp = (
                                int.Parse(((char)packet[0x4]).ToString()) * 10
                                + int.Parse(((char)packet[0x5]).ToString())
                            )
                            / 10.0;
                }
                else
                {
                    // int returned
                    temp = (payload[0x4] * 10 + payload[0x5]) / 10.0;
                }

                return temp;
            }

            // failure
            return double.MinValue;
        }

        /// <summary>
        /// Send Data from Pronto bytes
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<bool> SendPronto(byte[] data)
        {
            var raw = Signals.Pronto2Lirc(data);
            var bytes = Signals.Lirc2Broadlink(raw);

            //Xb.Util.Out(BitConverter.ToString(broadlinkBytes));
            return await SendData(bytes);
        }

        /// <summary>
        /// Send Data from Pronto-Format string.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<bool> SendPronto(string data)
        {
            return await SendPronto(Signals.String2ProntoBytes(data));
        }

        /// <summary>
        /// Learn IR command
        /// </summary>
        /// <param name="cancellationToken">Cancellation Token for IR learning</param>
        /// <returns>IR command</returns>
        /// <exception cref="InvalidOperationException">In case of failure</exception>
        /// <exception cref="TaskCanceledException">In case learning has benn cancelled</exception>
        public Task<byte[]> LearnIRCommnad(CancellationToken cancellationToken)
        {            
            return Task.Run(async () =>
            {
                try
                {
                    if (!await EnterLearning())
                        throw new InvalidOperationException("Failed to enter IR learning");

                    cancellationToken.ThrowIfCancellationRequested();

                    byte[] command = null;
                    while(null == (command = await CheckData()))
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        await Task.Delay(IRLearnIterval);
                    }

                    return command;
                }
                finally
                {
                    await CancelLearning();
                }
            }, cancellationToken);
        }

        #endregion Public Methods
    }
}
