using System.IO;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Declare necessary variables and compute the solution (x1, x2) of the quadratic equation formula: ax2 + bx + c = 0 */

            double a, b, c;     // coefficients

            Console.WriteLine("Quadratic formula a * x² + b * x + c = 0 solution calculator.");

            // Read inputs
            while (true)
            {
                Console.WriteLine("\nInput value for coefficient a: ");
                a = GetValidInput('a');

                if (a == 0) { Console.WriteLine("The value of coefficient a cannot be 0."); }
                else { break; }
            }

            Console.WriteLine("Input value for coefficient b: ");
            b = GetValidInput('b');
            
            Console.WriteLine("Input value for coefficient c: ");
            c = GetValidInput('c');

            // Calculate the discriminant
            double D = b * b - 4 * a * c;
            Console.WriteLine("\nD = " + D);

            if (D == 0D)
            {
                Console.WriteLine("D is equal to 0 => there is one real root.");
                double x = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("\nSolution: \nx1 = x2 = " + x);
            }
            else if (D > 0)
            {
                Console.WriteLine("D is greater than 0 => there are two real roots.");
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("\nSolution: \nx1 = " + x1 + "\nx2 = " + x2);
            }
            else if (D < 0)
            {
                Console.WriteLine("D is less than 0 => there are two complex roots.");
                double real = -b / 2 * a;
                double i = Math.Sqrt(Math.Abs(D)) / (2 * a);
                Console.WriteLine("\nSolution: \nx1 = " + real + " + " + i + " * i" + "\nx2 = " + real + " - " + i + " * i");
            }
        }

        static double GetValidInput(char coefficient)
        {
            double validInput;
            while (true)
            {
                try { validInput = Convert.ToDouble(Console.ReadLine()); break;  }
                catch {
                    Console.WriteLine($"Invalid input. The value of coefficient {coefficient} must be a real number.\n");
                    Console.WriteLine($"Input value for coefficient {coefficient}: ");
                }
            }

            return validInput;
        }
    }
}