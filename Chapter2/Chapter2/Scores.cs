using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    internal class Scores
    {
        static void Main()
        {
            double cs, java, python, php, network;
            double avg;
            Console.Write("Enter scores of CS =");
            cs = double.Parse(Console.ReadLine());
            Console.Write("Enter scores of Java =");
            java = double.Parse(Console.ReadLine());
            Console.Write("Enter scores of Python =");
            python = double.Parse(Console.ReadLine());
            Console.Write("Enter scores of php =");
            php = double.Parse(Console.ReadLine());
            Console.Write("Enter scores of network =");
            network = double.Parse(Console.ReadLine());

            avg = (cs + java + python + php + network) / 5;

            Console.WriteLine("\nC#\tJava\tPython\tPHP\tNetwork\n");
            Console.WriteLine($"{cs:0.00}\t{java:0.00}\t{python:0.00}\t{php:0.00}\t{network:0.00}\n");
            Console.ReadKey();
        }
    }
}
