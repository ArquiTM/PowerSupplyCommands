using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ivi.Visa.Interop;

namespace PowerSupplyCommands
{
    class LanCommands
    {
        public LanCommands()
        {

        }

        public bool SetVoltage()
        {
            try
            {
                return true;

            }
            catch
            {
                return false;
            }
        }
    }
}
