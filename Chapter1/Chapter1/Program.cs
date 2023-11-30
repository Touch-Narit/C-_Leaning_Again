using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    internal class Program
    {
        static void Mainx(string[] args)
        {
            Console.Clear(); //clrscr();

            Console.WriteLine("Hello world");
            Console.WriteLine("I study C#");

            int a = 10;
            Console.WriteLine("Value a = {0}",a);//printf("values a=%d",a);
            Console.WriteLine($"Value a = {a}");
            int b = 20;
            Console.WriteLine($"Values a ={a} and Value b={b}");

            double total = 45.8374457;
            Console.WriteLine($"Values total ={total:0.00}");
            Console.WriteLine($"Values total ={total:c2}");
            Console.WriteLine($"Values total ={total:#,##0.00 R}");


            Console.ReadKey(); //getch();
        }
    }
}
