using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProjektConsolowy
{
    internal class Utility
    {
        public static void Hello()
        {
            Console.WriteLine("Hello from utility");
        }

        public static void AddTwoNumbers(int a, int b)
        {
            return (int)(a + b);
        }

        public static void MulltiplyThreeNumbers(int a, int b, int c) 
        {
            return (int)(a * b * c);
        }
    }
}