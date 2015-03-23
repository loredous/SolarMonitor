using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarMonitor.BaseClasses
{
    public class MessageBase
    {
        public string Sender { get; internal set; }
        public Guid MessageID { get; internal set; }
        public Guid ComponentID { get; internal set; }
    }
}
