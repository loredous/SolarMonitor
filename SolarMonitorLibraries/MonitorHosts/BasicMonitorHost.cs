using SolarMonitor.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarMonitor.MonitorHosts
{
    public class BasicMonitorHost : MonitorHostBase
    {
        public void Initialize(MonitorModuleBase[] ModulesToLoad)
        {
            foreach (MonitorModuleBase ModuleToLoad in ModulesToLoad)
            {
                base.LoadModule(ModuleToLoad);
            }
            
        }
        internal override void HandleAvailableData(object sender, MessageAvailableArgs e)
        {
            base.OnMessageAvailable(e);
        }
    }
}
