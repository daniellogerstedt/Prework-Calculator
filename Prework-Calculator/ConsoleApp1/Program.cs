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
            if (args.Length == 3 && int.TryParse(args[0], out int a) && int.TryParse(args[1], out int b))
                switch (args[2])
                {
                    case "add":
                        Console.WriteLine(Program.add(a, b));
                        break;

                    case "subtract":
                        Console.WriteLine(Program.subtract(a, b));
                        break;

                    case "multiply":
                        Console.WriteLine(Program.multiply(a, b));
                        break;

                    case "divide":
                        Console.WriteLine(Program.divide(a, b));
                        break;

                    default:
                        Console.WriteLine("Please provide 2 integers and an action (add, subtract, multiply, divide).");
                        break;
                }
            else Console.WriteLine("Please provide 2 integers and an action (add, subtract, multiply, divide).");
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
    }
}
