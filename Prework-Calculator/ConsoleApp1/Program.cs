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
            if (args.Length == 3)
                switch (args[2])
                {
                    case "add":
                        Console.WriteLine(Program.add(args[0], args[1]));
                        break;

                    case "subtract":
                        Console.WriteLine(Program.subtract(args[0], args[1]));
                        break;

                    case "multiply":
                        Console.WriteLine(Program.multiply(args[0], args[1]));
                        break;

                    case "divide":
                        Console.WriteLine(Program.divide(args[0], args[1]));
                        break;

                    default:
                        Console.WriteLine("Please provide 2 numbers and an action (add, subtract, multiply, divide).");
                        break;
                }
            else Console.WriteLine("Please provide 2 numbers and an action (add, subtract, multiply, divide).");
        }

    }
}
