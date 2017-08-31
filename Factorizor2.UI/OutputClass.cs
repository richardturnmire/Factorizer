using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor2.UI
{
    public static class OutputClass
    {
        public static void SentToConsole(string str)
        {
                           
                Console.WriteLine(str);
            
        }
        public static void SentToConsole(string str, bool WaitforResponse)
        {

            Console.WriteLine(str);
            if (WaitforResponse)
            {
                Console.WriteLine("/nPress any key to continue...");
                Console.ReadKey();
            }
            
        }
    }
}
