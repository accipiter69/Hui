using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlia_vsego
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите выражение: ");
            string expression = Console.ReadLine();
            string firstOp = "";
            string secondOp = "";
            char? oper = null;
            double result;
            
            foreach (char ch in expression)

            {
                if (ch == ' ')
                {
                    continue;
                }
                if (ch == '+' || ch=='-' || ch=='*' ||ch=='/')
                {
                    oper = ch;
                }
                else if (oper == null)
                {
                    firstOp += ch;

                }
                else 
                {
                    secondOp += ch;
                }
                
            }


            double a,b;

            if (double.TryParse(firstOp, out a) ==false)
            {
                Console.WriteLine("ИДИ НАХУЙ a");
                return;
            }
            if (double.TryParse(secondOp, out b) == false)
            {
                Console.WriteLine("ИДИ НАХУЙ b");
                return;
            }


            switch (oper)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
                default:
                    Console.WriteLine("ИДИ НАХУЙ, ОПЕРАЦИЯ!");
                    return;
                
            }

            Console.WriteLine($"Результат:{result} ");

            Console.ReadKey();
        }

        



                    

                
               
           





               
       
    }
}
