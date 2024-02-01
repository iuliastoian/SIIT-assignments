using System.Text;

namespace IuliaTiaStoian_ROT3chiper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declared and defined input value
            string? input = Console.ReadLine();

            // validated input value
            if (input == null) { Console.WriteLine("Input must not be empty. Retry."); return;  }

            // create empty StringBuilder
            StringBuilder sb = new StringBuilder(input.Length);

            // compute the ROT3 cipher
            for (int i = 0; i < input.Length; i++)
            {

                sb.Append((char)((int)input[i] + 3));
            }

            // show the result
            Console.WriteLine(sb.ToString());
        }
    }
}