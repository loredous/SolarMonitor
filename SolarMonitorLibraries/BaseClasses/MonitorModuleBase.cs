using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarMonitor.BaseClasses
{
    public abstract class MonitorModuleBase
    {
        internal MonitorHostBase Host;
        internal Guid MonitorID = Guid.NewGuid();

        public EventHandler<MessageAvailableArgs> DataAvailable;

        internal void OnDataAvailable(MessageAvailableArgs e)
        {
            if (this.DataAvailable != null)
            {
                DataAvailable(this, e);
            }
        }

        public virtual bool Initialize(MonitorHostBase Host)
        {
            this.Host = Host;
            Host.MessageAvailable += HostMessageAvailable;
            return true;
        }

        internal virtual void HostMessageAvailable(object sender, MessageAvailableArgs e)
        {
            //Do nothing by default
        }

        public abstract void Start();
        public abstract void Stop();
    }


}
