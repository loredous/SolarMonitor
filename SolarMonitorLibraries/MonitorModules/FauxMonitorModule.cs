using SolarMonitor.BaseClasses;
using SolarMonitor.MessageTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarMonitor.MonitorModules
{
    public class FauxMonitorModule : MonitorModuleBase
    {
        public override bool Initialize(MonitorHostBase Host)
        {
            this.Host = Host;
            Host.MessageAvailable += HostMessageAvailable;
            return true;
        }

        internal override void HostMessageAvailable(object sender, MessageAvailableArgs e)
        {
            if  (e.Message.ComponentID != MonitorID)
            {
                int a = 2;
            }
        }

        public void Test()
        {
            this.OnDataAvailable(new MessageAvailableArgs() { Message = new DataMessageType("FauxMonitor",MonitorID,new KeyValuePair<string, string>[] { })});
        }

        public override void Start()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
