using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public  class EcosystemDeviceNotificationService
    {
        public string Message;
        public EcosystemDeviceNotificationService(string message)
        {
            Message = message;
        }
        public List<INotify> Notifier = new List<INotify>();
        public void AddDevicesToNotify(INotify notifier)
        {
            Notifier.Add(notifier);
        }
        public void Notify()
        {
            foreach (INotify notifier in Notifier)
            {
                notifier.Notify(Message);
            }
        }
    }
}
