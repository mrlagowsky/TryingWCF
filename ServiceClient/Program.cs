using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            DayLogServiceReference.DayLogServiceClient proxy = new DayLogServiceReference.DayLogServiceClient();
            string message = proxy.GetData(101);
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
