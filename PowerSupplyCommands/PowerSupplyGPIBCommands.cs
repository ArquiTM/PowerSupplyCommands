using System;
using NationalInstruments.VisaNS;

namespace PowerSupplyCommands
{
    public class GPIBCommands
    {
        public GPIBCommands()
        {

        }
        public bool SetVoltage(string addressPowerSupply, double voltage)
        {
            try
            {
                MessageBasedSession mBs = new MessageBasedSession(addressPowerSupply);
                mBs.Write("VOLT " + voltage + ";*OPC?");
                if (Convert.ToInt32(mBs.ReadString()) != 1)
                    return false;

                return true;
            }
            catch { return false; }
        }

        public double ReadVoltage(string addressPowerSupply)
        {
            try
            {
                MessageBasedSession mBs = new MessageBasedSession(addressPowerSupply);
                mBs.Write("MEAS:VOLT?");
                return Convert.ToInt32(mBs.ReadString());
            }
            catch
            { return -999; }
        }

        public bool SetMaxCurrent(string addressPowerSupply, double current)
        {
            try
            {
                MessageBasedSession mBs = new MessageBasedSession(addressPowerSupply);
                mBs.Write("CURR:LIM:VAL " + current + ";*OPC?");
                if (Convert.ToInt32(mBs.ReadString()) != 1)
                    return false;

                return true;
            }
            catch
            { return false; }
        }

        public double ReadCurrent(string addressPowerSupply)
        {
            try
            {
                MessageBasedSession mBs = new MessageBasedSession(addressPowerSupply);
                mBs.Write("MEAS:CURR?");
                return Convert.ToInt32(mBs.ReadString());
            }
            catch { return -999; }
        }

        public bool OutputOn(string addressPowerSupply)
        {
            try
            {
                MessageBasedSession mBs = new MessageBasedSession(addressPowerSupply);
                mBs.Write("OUTP On;*OPC?");
                if (Convert.ToInt32(mBs.ReadString()) != 1)
                    return false;

                return true;
            }
            catch
            { return false; }
        }

        public bool OutputOff(string addressPowerSupply)
        {
            try
            {
                MessageBasedSession mBs = new MessageBasedSession(addressPowerSupply);
                mBs.Write("OUTP Off;*OPC?");
                if (Convert.ToInt32(mBs.ReadString()) != 1)
                    return false;

                return true;
            }
            catch
            { return false; }
        }
    }
}
