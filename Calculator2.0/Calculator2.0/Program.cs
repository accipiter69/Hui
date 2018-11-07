using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            string i = "да";
            while (i == "да")
            {
                Console.Write("Введите число 1: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите действие: ");
                string c = Console.ReadLine();
                Console.Write("Введите число 2: ");
                double b = Convert.ToDouble(Console.ReadLine());

                double? d = null;

                if (c == "+")
                {
                    d = a + b;
                }
                else if (c == "-")
                {
                    d = a - b;
                }
                else if (c == "*")
                {
                    d = a * b;
                }
                else if (c == "/")
                {
                    d = a / b;
                }
                Console.WriteLine(d);
                Console.WriteLine("Ходите продолжить? ");
                i = Console.ReadLine();
            }  



           

        }
    } 
}
