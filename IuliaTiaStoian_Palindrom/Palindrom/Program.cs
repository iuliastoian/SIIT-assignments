using System.Text;
using System.Text.RegularExpressions;

namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started. Type your input... (Press CTRL + C to stop the program when finished testing)");
            
            while (true)
            {
                // declared and defined input value
                string? input = Console.ReadLine();

                // validated input value
                if (input == null) { Console.WriteLine("Input must not be empty. Retry."); return; }

                // remove white spaces and digits
                Regex rgx = new Regex(@"[\s0-9]+");
                string output = rgx.Replace(input, "");

                // remove symbols
                rgx = new Regex(@"[^\w]");
                output = rgx.Replace(output, "");

                // compute the ROT3 cipher
                bool isPalindrom = true;
                for (int i = 0; i < output.Length / 2; i++)
                {
                    if (output[i] != output[output.Length - i - 1]) { isPalindrom = false; break; }
                }

                // show the result
                if (isPalindrom) { Console.WriteLine("This is a palindrome."); }
                else
                {
                    Console.WriteLine("Nu este palindrom.");
                }
            }
        }
    }
}