using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    internal class Product
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            double p1, p2, p3, dis, total, disPrice, payment;
            Console.Write("Enter P1=$");
            p1=double.Parse(Console.ReadLine());
            Console.Write("Enter P2=$");
            p2=double.Parse(Console.ReadLine());
            Console.Write("Enter P3=$");
            p3=double.Parse(Console.ReadLine());
            Console.Write("Enter Discount=");
            dis=double.Parse(Console.ReadLine());

            total = p1 + p2 + p3;
            disPrice = total * dis / 100;
            payment = total - disPrice;
            Console.BackgroundColor= ConsoleColor.Green;
            Console.WriteLine("========================");
            Console.WriteLine($"Total ={total:c2}");
            Console.WriteLine($"discount = {dis} %");
            Console.WriteLine($"disPrice = {disPrice:c2}");
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine($"Payment = {payment:c2}");

            Console.ReadKey();
        }
    }
}
