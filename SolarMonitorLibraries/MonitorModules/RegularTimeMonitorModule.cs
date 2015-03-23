using SolarMonitor.BaseClasses;
using SolarMonitor.MessageTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SolarMonitor.MonitorModules
{
    public class RegularTimeMonitorModule : MonitorModuleBase
    {
        Timer a = new Timer();
        public override void Start()
        {
            a.Interval = 5000;
            a.Elapsed += OnTimerElapsed;
            a.Start();
        }

        public override void Stop()
        {
            a.Stop();
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            base.DataAvailable(this, new MessageAvailableArgs() { Message = new DataMessageType("Timer", this.MonitorID, new KeyValuePair<string, string>[] { new KeyValuePair<string, string>("Time", DateTime.Now.ToLongTimeString()) }) });
        }
    }
}
