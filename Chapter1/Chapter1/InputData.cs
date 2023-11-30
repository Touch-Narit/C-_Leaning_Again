using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    internal class InputData
    {
        static void Mainx()
        {
            Console.Clear();
            int a;
            long b;
            double p1;
            string name;

            Console.Write("Enter a=");
            a=int.Parse(Console.ReadLine());
            Console.Write("Enter b=");
            b=long.Parse(Console.ReadLine());
            Console.Write("Enter p1=");
            p1=double.Parse(Console.ReadLine());
            Console.Write("Enter full name=");
            name=Console.ReadLine();


            Console.ReadKey();
        }
    }
}
