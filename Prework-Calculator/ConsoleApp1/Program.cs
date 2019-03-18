using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The First Number:");
            string first = Console.ReadLine();

            Console.WriteLine("Please Enter The Second Number:");
            string second = Console.ReadLine();

            Console.WriteLine("Please Enter The Action:");
            string action = Console.ReadLine();

            if (int.TryParse(first, out int a) && int.TryParse(second, out int b))
                switch (action)
                {
                    case "add":
                        Console.WriteLine("Your answer is: " + Program.add(a, b));
                        break;

                    case "subtract":
                        Console.WriteLine("Your answer is: " + Program.subtract(a, b));
                        break;

                    case "multiply":
                        Console.WriteLine("Your answer is: " + Program.multiply(a, b));
                        break;

                    case "divide":
                        Console.WriteLine("Your answer is: " + Program.divide(a, b));
                        break;

                    default:
                        Console.WriteLine("Please provide 2 integers and an action (add, subtract, multiply, divide).");
                        break;
                }
            else Console.WriteLine("Please provide 2 integers and an action (add, subtract, multiply, divide).");

            Console.WriteLine("Press Return/Enter to exit.");
            Console.ReadLine();
        }

        static int add(int a, int b)
        {
            return a + b;
        }

        static int subtract(int a, int b)
        {
            return a - b;
        }

        static int multiply(int a, int b)
        {
            return a * b;
        }

        static int divide(int a, int b)
        {
            if (b == 0) return 0;
            return (int) a / b;
        }
    }
}
