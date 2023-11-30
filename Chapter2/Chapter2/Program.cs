using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    internal class Program
    {
        static void Mainx(string[] args)
        {
            Console.Clear();

            bool b1;
            int a = 5, b = 3;
            b1 = a > b;

            if (b1)
            {
                Console.WriteLine("a>b");
            }
            else
                Console.WriteLine("a<=b");


            Console.ReadKey();
        }
    }
}
