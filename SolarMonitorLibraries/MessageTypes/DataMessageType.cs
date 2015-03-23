using SolarMonitor.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SolarMonitor.MessageTypes
{
    public class DataMessageType : MessageBase
    {
        public KeyValuePair<string,string>[] DataPoints { get; private set; }

        public DataMessageType(string Sender, Guid ComponentID, KeyValuePair<string,string>[] DataPoints)
        {
            this.Sender = Sender;
            this.ComponentID = ComponentID;
            this.DataPoints = DataPoints;
            this.MessageID = Guid.NewGuid();
        }
    }
}
