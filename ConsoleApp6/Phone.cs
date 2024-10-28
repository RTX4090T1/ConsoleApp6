using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Phone: INotify
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Message from Phone: {message}");
        }
    }
}
