using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    internal class TestConvert
    {
        static void Mainx()
        {
            //Expression, Operation, Type, Variable, and Constants

            int a = 3;
            int b = 10;
            int max = a > b ? a : b;
            Console.WriteLine(max);

            //Console.WriteLine("I study at \"Techno\"");
            //const double uniprice = 5;
            //int qty = 100;
            //double total;


            //total = uniprice * qty;
            //Console.WriteLine($"Total ={total}");


            //byte b = 23;
            //int a = b;
            //long l = a;
            //double d = l;

            //a = 68;
            //b = (byte)a;

            //Console.WriteLine($"b ={b}");



            //int id = 7;
            //double total = 34.46;

            //string idstring = id.ToString("000");
            //string totalstring = total.ToString("c2");

            //Console.WriteLine($"idstring = {idstring}");
            //Console.WriteLine($"totalstring = {totalstring}");


            //double price1, price2;
            //Console.Write("Enter Price $=");
            //price1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter Price $=");
            //price2= Convert.ToDouble(Console.ReadLine());

            //string st = "34";
            //int x = int.Parse(st);
            //double y = double.Parse(st);


            //int a = Convert.ToInt32(x);
            //double b = Convert.ToDouble(y);

            //Console.WriteLine($"x={x}");
            //Console.WriteLine($"y={y}");
            //Console.WriteLine($"a={a}");
            //Console.WriteLine($"b={b}");

            Console.ReadKey();
        }
    }
}
