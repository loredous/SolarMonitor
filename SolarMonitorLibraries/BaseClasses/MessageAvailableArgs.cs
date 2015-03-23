using SolarMonitor.MessageTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarMonitor.BaseClasses
{
    public class MessageAvailableArgs : EventArgs
    {
        public MessageBase Message;
    }
}
