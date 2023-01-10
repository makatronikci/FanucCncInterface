using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace FanucCncInterface
{
    /// <summary>
    /// This library prepared for some specific Focas functions.
    /// Usage: Connect => Preferet functions => Disconnect
    /// </summary>
    public class CncInterface
    {
        private ushort Handle;

        private ProductionData production = new ProductionData();

        /// <summary>
        /// Use for cnc connection
        /// </summary>
        /// <param name="ip">Type cnc ip as string</param>
        /// <param name="port">Type port number as ushort</param>
        /// <returns>It returns as EventResult.</returns>
        public EventResult ConnectFanuc(string ip, ushort port)
        {
            short ret = Focas1.cnc_allclibhndl3(ip, port, 30, out Handle);
            if (ret == Focas1.EW_OK)
            {
                return EventResult.Success;
            }
            else
            {
                return EventResult.Fail;
            }
        }

        /// <summary>
        /// Use for cnc disconnection
        /// </summary>
        /// <returns>It returns as EventResult.</returns>
        public EventResult DisconnectFanuc()
        {
            short ret = Focas1.cnc_freelibhndl(Handle);
            if (ret == Focas1.EW_OK)
            {
                return EventResult.Success;
            }
            else
            {
                return EventResult.Fail;
            }
        }

        /// <summary>
        /// Use for writing 4 byte data. You can use this for integer positive and negative values.
        /// </summary>
        /// <param name="start">Type data starting adress. For example if you type 0, it will write to D0000-D0003</param>
        /// <param name="value">Type integer value to be written</param>
        /// <returns>It returns as EventResult.</returns>
        public EventResult WriteDDataFourByte(ushort start, int value)
        {
            short ret, ret2;
            ushort length;
            ushort end = (ushort)(start + 3);

            Focas1.IODBPMC rData = new Focas1.IODBPMC();

            length = (ushort)(8 + (end - start + 1));
            ret = Focas1.pmc_rdpmcrng(Handle, 9, 0, start, end, length, rData);
            if (ret == Focas1.EW_OK)
            {
                rData.ldata[0] = value;
                ret2 = Focas1.pmc_wrpmcrng(Handle, length, rData);
                if (ret2 == Focas1.EW_OK)
                {
                    return EventResult.Success;
                }
                else
                {
                    return EventResult.Fail;
                }



            }
            else
            {
                return EventResult.Fail;
            }
        }

        /// <summary>
        /// Use for writing data to just one bit.
        /// </summary>
        /// <param name="number">Type data number</param>
        /// <param name="bitNumber">Type bit number</param>
        /// /// <param name="value">Type boolean value to be written</param>
        /// <returns>It returns as EventResult.</returns>
        public EventResult WriteDSignal(ushort number, short bitNumber, bool value)
        {
            short ret, ret2;
            Focas1.IODBPMC rSIGNAL = new Focas1.IODBPMC();
            ret = Focas1.pmc_rdpmcrng(Handle, 9, 0, number, number, 9, rSIGNAL);
            if (ret == Focas1.EW_OK)
            {
                BitArray b = new BitArray(new int[] { rSIGNAL.ldata[0] });
                b[bitNumber] = value;

                rSIGNAL.ldata[0] = getIntFromBitArray(b);

                ret2 = Focas1.pmc_wrpmcrng(Handle, 9, rSIGNAL);
                if (ret2 == Focas1.EW_OK)
                {
                    return EventResult.Success;
                }
                else
                {
                    return EventResult.Fail;
                }
            }
            else
            {
                return EventResult.Fail;
            }
        }

        /// <summary>
        /// Use for reading data signals.
        /// </summary>
        /// <param name="number">Type data number</param>
        /// <returns>It returns as BitArray or EventResult.Fail</returns>
        public object ReadDSignals(ushort number)
        {
            short ret;
            Focas1.IODBPMC rSIGNAL = new Focas1.IODBPMC();
            ret = Focas1.pmc_rdpmcrng(Handle, 9, 0, number, number, 9, rSIGNAL);
            if (ret == Focas1.EW_OK)
            {
                BitArray b = new BitArray(new int[] { rSIGNAL.ldata[0] });
                return b;
            }
            else
            {
                return EventResult.Fail;
            }
        }

        /// <summary>
        /// Use for reading 4 byte data.
        /// </summary>
        /// <param name="start">Type data starting adress. For example if you type 0, it will read to D0000-D0003</param>
        /// <returns>It returns as Integer or EventResult.Fail</returns>
        public object ReadDDataFourByte(ushort start)
        {
            short ret;
            ushort length;
            ushort end = (ushort)(start + 3);

            Focas1.IODBPMC rData = new Focas1.IODBPMC();

            length = (ushort)(8 + (end - start + 1));
            ret = Focas1.pmc_rdpmcrng(Handle, 9, 0, start, end, length, rData);
            if (ret == Focas1.EW_OK)
            {
                return rData.ldata[0];
            }
            else
            {
                return EventResult.Fail;
            }
        }

        /// <summary>
        /// Use for reading production data.
        /// </summary>
        /// <returns>It returns as ProductionData or EventResult.Fail</returns>
        public object CollectPRoductionData()
        {
            try
            {
                cycleValue();
                totalCycleValue();
                partsCounter();
                status();
                toolNumber();
                programNumber();

                return production;
            }
            catch (Exception)
            {
                ProductionData pr = new ProductionData();
                production = pr;
                return EventResult.Fail;
            }

        }

        /// <summary>
        /// Use for writing to maco registers.
        /// </summary>
        /// <param name="number">Type macro register number</param>
        /// <param name="value">Type integer value</param>
        /// <param name="dec">Type the number of places of decimals/exponent part of variable</param>
        /// <returns>It returns as EventResult.</returns>
        public EventResult WriteMacro(short number, int value, short dec)
        {
            /**
            short right = 0;
            string strValue = value.ToString();

            bool commaCheck = strValue.Contains(",");
            if (commaCheck)
            {
                string[] stringParts = strValue.Split(",");
                right = (short)stringParts[1].Length;
                strValue = stringParts[0] + stringParts[1];
            }

            bool pointCheck = strValue.Contains(".");
            if (pointCheck)
            {
                string[] stringParts = strValue.Split(".");
                right = (short)stringParts[1].Length;
                strValue = stringParts[0] + stringParts[1];
            }

            int newValue = Convert.ToInt32(strValue); */

            short ret = Focas1.cnc_wrmacro(Handle, number, (short)10, value, dec);
            if (ret == Focas1.EW_OK)
            {
                return EventResult.Success;
            }
            else
            {
                return EventResult.Fail;
            }
        }

        /// <summary>
        /// Use for reading to maco registers.
        /// </summary>
        /// <param name="number">Type macro register number</param>
        /// <returns>It returns as macro register value or EventResult.Fail</returns>
        public object ReadMacro(short number)
        {

            Focas1.ODBM c = new Focas1.ODBM();
            short ret = Focas1.cnc_rdmacro(Handle, number, 10, c);
            if (ret == Focas1.EW_OK)
            {
                return c.mcr_val / Math.Pow(10, c.dec_val);
            }
            else
            {
                return EventResult.Fail;
            }
        }

        private int getIntFromBitArray(BitArray bitArray)
        {

            if (bitArray.Length > 32)
                throw new ArgumentException("Argument length shall be at most 32 bits.");

            int[] array = new int[1];
            bitArray.CopyTo(array, 0);
            return array[0];

        }

        private void status()
        {
            Focas1.ODBST a = new Focas1.ODBST();
            short ret = Focas1.cnc_statinfo(Handle, a);
            if ((ret == Focas1.EW_OK))
            {
                if (a.run == 3)
                {
                    production.CycleSignal = true;
                }
                else
                {
                    production.CycleSignal = false;
                }
                if (a.alarm == 1)
                {
                    production.AlarmSignal = true;
                }
                else
                {
                    production.AlarmSignal = false;
                }
            }
        }

        private void cycleValue()
        {
            Focas1.IODBTIME b = new Focas1.IODBTIME();

            short ret = Focas1.cnc_rdtimer(Handle, 3, b);
            if (ret == Focas1.EW_OK)
            {
                production.CycleH = Convert.ToInt32(b.minute / 60);
                production.CycleM = b.minute % 60;
                production.CycleS = Convert.ToInt32(b.msec / 1000);
            }
        }

        private void totalCycleValue()
        {
            Focas1.IODBTIME b = new Focas1.IODBTIME();

            short ret = Focas1.cnc_rdtimer(Handle, 1, b);
            if (ret == Focas1.EW_OK)
            {
                production.TotalCycleH = Convert.ToInt32(b.minute / 60);
                production.TotalCycleM = b.minute % 60;
                production.TotalCycleS = Convert.ToInt32(b.msec / 1000);
            }
        }

        private void partsCounter()
        {
            Focas1.IODBPSD_1 d = new Focas1.IODBPSD_1();
            short ret = Focas1.cnc_rdparam(Handle, 6711, Focas1.ALL_AXES, 4 + 1 * Focas1.MAX_AXIS, d);
            if (ret == Focas1.EW_OK)
            {
                production.PartCounter = d.ldata;
            }
        }

        private void toolNumber()
        {
            Focas1.ODBM c = new Focas1.ODBM();
            short ret = Focas1.cnc_rdmacro(Handle, 4120, 10, c);
            if (ret == Focas1.EW_OK)
            {
                string strVal;
                strVal = string.Format("{0:d9}", Math.Abs(c.mcr_val));
                if (0 < c.dec_val) strVal = strVal.Insert(9 - c.dec_val, ".");
                if (c.mcr_val < 0) strVal = "-" + strVal;

                int index = strVal.IndexOf('.');
                string result = strVal.Substring(0, index);
                production.Tool = Convert.ToInt32(result);
            }
        }

        private void programNumber()
        {
            Focas1.ODBPRO a = new Focas1.ODBPRO();
            short ret = Focas1.cnc_rdprgnum(Handle, a);
            if (ret == Focas1.EW_OK)
            {
                production.Program = a.mdata;
            }
        }

    }
}