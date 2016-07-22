using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnParQ2
{
    class Program
    {
        static void Main(string[] args)
        {

            string replay = "yes";

            while (replay == "yes")
            {
                Console.WriteLine("Please enter a number");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter in operation ( +, - , *, /) ");
                string arithmetic = Console.ReadLine();

                Console.WriteLine("Enter a second number");
                int y = Convert.ToInt32(Console.ReadLine());

                switch (arithmetic)
                {
                    case "+":
                        Console.WriteLine(x + "" + arithmetic + "" + y + "=" + Sum(x, y) + '\n');
                        break;

                    case "-":
                        Console.WriteLine(x + "" + arithmetic + "" + y + "=" + diff(x, y) + '\n');
                        break;

                    case "*":
                        Console.WriteLine(x + "" + arithmetic + "" + y + "=" + MultiplyEm(x, y) + '\n');
                        break;

                    case "/":
                        Console.WriteLine(x + ""+ arithmetic + "" + y + "=" + divide(x,y) + '\n');
                        
                        break;

                    default:
                        Console.WriteLine("You did not enter the correct operator");
                        Bye();
                        break;
                }
                Console.WriteLine("Would you like to do another equation? (yes/no)");
                replay = Console.ReadLine().ToLower();
            }
            Bye();
        }

        //goodbye
        static void Bye()
        {
            Console.WriteLine("Goodbye");
        }

        //Addition method
        static int Sum(int x, int y)
        {
            int z = x + y;
            return z;
        }

        //Subtracton method
        static int diff(int c, int d)
        {
            int e = c - d;
            return e;
        }

        //Multiplication method
        static int MultiplyEm(int thing1, int thing2)
        {
            int truth = thing1 * thing2;
            return truth;
        }

        //Division method
        static int divide(int x, int y)
        {
            int t = x / y;
            return t;
        }
    }
}
