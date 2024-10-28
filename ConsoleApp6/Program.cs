using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program 
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            var phone = new Phone();
            var watch = new Watch();
            var earPhones = new EarPhones();
            EcosystemDeviceNotificationService es = new EcosystemDeviceNotificationService(message);

            es.AddDevicesToNotify(phone);
            es.AddDevicesToNotify(earPhones);
            es.AddDevicesToNotify(watch);

            es.Notify();
        }
    }
}
