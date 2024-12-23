using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number:");
            if (!Int32.TryParse(Console.ReadLine(),out var a))
            {
                Console.WriteLine("Not a number!");
                return;
            }

            Console.WriteLine("Please enter the second number:");
            if (!Int32.TryParse(Console.ReadLine(), out var b))
            {
                Console.WriteLine("Not a number!");
                return;
            }
            Console.WriteLine("Please enter the symbol for the calculation: +, -, *, /, %");
            Console.WriteLine("Please enter the character for the calculation in decimal, binary and hexadecimal form.: ^, &, |");
            var s = Console.ReadLine();
            //var boolVar = true;
            //if (s.Length == 0 || s.Length > 1 && !boolVar)
            //{
            //    Console.WriteLine("Wrong sign");
            //} 
            switch (s[0])
            {
                case '+':
                    Console.WriteLine("Result of {0} + {1} = {2}", a, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("Result of {0} - {1} = {2}", a, b, a - b);
                    break;
                case '*':
                    Console.WriteLine("Result of {0} * {1} = {2}", a, b, a * b);
                    break;
                case '/':
                    Console.WriteLine("Result of {0} / {1} = {2}", a, b, a / b);
                    break;
                case '%':
                    Console.WriteLine("Result of {0} % {1} = {2}", a, b, a % b);
                    break;
                case '&':
                    int Res1 = a & b;
                    Console.WriteLine("Result of {0} & {1} = {2} (Decimal: {3}, Binary: {4}, Hexadecimal: {5})",
                        a, b, Res1, Res1, Convert.ToString(Res1, 2), Res1.ToString("X"));
                    break;
                case '|':
                    int Res2 = a | b;
                    Console.WriteLine("Result of {0} | {1} = {2} (Decimal: {3}, Binary: {4}, Hexadecimal: {5})",
                        a, b, Res2, Res2, Convert.ToString(Res2, 2), Res2.ToString("X"));
                    break;
                case '^':
                    int Res3 = a ^ b;
                    Console.WriteLine("Result of {0} ^ {1} = {2} (Decimal: {3}, Binary: {4}, Hexadecimal: {5})",
                        a, b, Res3, Res3, Convert.ToString(Res3, 2), Res3.ToString("X"));
                    break;
                default:
                    Console.WriteLine("Wrong sign");
                    break;
            }

            Console.ReadKey();

        }
    }
}
