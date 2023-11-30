using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    internal class UserNameAndPassword
    {
        static void Mainx()
        {
            Console.Clear();

            string userName, password;
            Console.Write("Enter user name=");
            userName = Console.ReadLine();
            Console.Write("Enter password =");
            password = Console.ReadLine();

            if(userName=="rith" && password == "v001")
            {
                Console.Clear() ;
                int a, b, sum;
                Console.Write("Enter a=");
                a = int.Parse(Console.ReadLine());
                Console.Write("Enter b=");
                b = int.Parse(Console.ReadLine());

                sum = a + b;

                Console.WriteLine("==================");
                Console.WriteLine($"Total sum ={sum }");

            }
            else if(userName=="rith")
            {
                Console.WriteLine("Incorrect password");
            }
            else
            {
                Console.WriteLine("Invalided user name");
            }

            Console.ReadKey();
        }
    }
}
