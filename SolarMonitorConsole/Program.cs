using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolarMonitor;
using SolarMonitor.BaseClasses;
using SolarMonitor.MonitorHosts;
using SolarMonitor.MonitorModules;
using System.Threading;
using SolarMonitor.MessageTypes;

namespace SolarMonitorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicMonitorHost a = new BasicMonitorHost();
            RegularTimeMonitorModule b = new RegularTimeMonitorModule();
            FauxMonitorModule c = new FauxMonitorModule();
            a.Initialize(new MonitorModuleBase[] { b,c});
            a.MessageAvailable += HandleMessages;
            b.Start();
            c.Test();
            Thread.Sleep(1000);
            c.Test();
            Thread.Sleep(1000);
            c.Test();
            Console.ReadLine();
            b.Stop();
        }

        private static void HandleMessages(object sender, MessageAvailableArgs e)
        {
            Console.WriteLine("Sender: {0}", e.Message.Sender);
            Console.WriteLine("MessageID: {0}", e.Message.MessageID.ToString());
            foreach (KeyValuePair<string,string> item in (e.Message as DataMessageType).DataPoints)
            {
                Console.WriteLine("{0} -- {1}", item.Key, item.Value);
            }
        }
    }
}
