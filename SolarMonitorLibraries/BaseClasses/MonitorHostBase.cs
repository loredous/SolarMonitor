using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarMonitor.BaseClasses
{
    public abstract class MonitorHostBase
    {
        public EventHandler<MessageAvailableArgs> MessageAvailable;
        private List<MonitorModuleBase> Modules = new List<MonitorModuleBase>();

        public void Initialize()
        {

        }

        internal void OnMessageAvailable(MessageAvailableArgs e)
        {
            if (this.MessageAvailable != null)
            {
                this.MessageAvailable(this, e);
            }
        }

        internal void LoadModule(MonitorModuleBase Module)
        {
            if (Module != null)
            {
                Modules.Add(Module);
                Module.Initialize(this);
                Module.DataAvailable += HandleAvailableData;
            }
        }

        internal abstract void HandleAvailableData(object sender, MessageAvailableArgs e);
    }
}
