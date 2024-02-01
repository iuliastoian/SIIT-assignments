namespace IuliaTiaStoian_NoToStr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started... Type a number between 0-999. (Press CTRL + C to stop the program when you're done testing)");
            while (true)
            {
                int input;
                try
                {
                    input = UInt16.Parse(Console.ReadLine());
                } catch {
                    Console.WriteLine("Invalid input. Type a number between 0-999.");
                    return;
                }

                if (input == 0) { Console.WriteLine("zero"); continue; }

                getDigit(input / 100);
                if (input > 99) { Console.Write(" hundred "); }
                getTens(input % 100 / 10, input % 10);
                Console.WriteLine();
            }
        }

        static void getDigit(int digit)
        {
            switch (digit)
            {
                case 1: Console.Write("one"); break;
                case 2: Console.Write("two"); break;
                case 3: Console.Write("three"); break;
                case 4: Console.Write("four"); break;
                case 5: Console.Write("five"); break;
                case 6: Console.Write("six"); break;
                case 7: Console.Write("seven"); break;
                case 8: Console.Write("eight"); break;
                case 9: Console.Write("nine"); break;
            }
        }

        static void getTens(int tens, int units)
        {
            if (tens == 1) { 
                switch (units)
                {
                    case 0: Console.Write("ten"); break;
                    case 1: Console.Write("eleven"); break;
                    case 2: Console.Write("twelve"); break;
                    case 3: Console.Write("thirteen"); break;
                    case 4: Console.Write("fourteen"); break;
                    case 5: Console.Write("fifteen"); break;
                    case 6: Console.Write("sixteen"); break;
                    case 7: Console.Write("seventeen"); break;
                    case 8: Console.Write("eighteen"); break;
                    case 9: Console.Write("nineteen"); break;

                }
                return;
            }

            switch (tens)
            {
                case 0: getDigit(units); break;
                case 2: { Console.Write("twenty"); if (units != 0) { Console.Write("-"); } getDigit(units); } break;
                case 3: { Console.Write("thirty"); if (units != 0) { Console.Write("-"); } getDigit(units); } break;
                case 4: { Console.Write("fourty"); if (units != 0) { Console.Write("-"); } getDigit(units); } break;
                case 5: { Console.Write("fifty"); if (units != 0) { Console.Write("-"); } getDigit(units); } break;
                case 6: { Console.Write("sixty"); if (units != 0) { Console.Write("-"); } getDigit(units); } break;
                case 7: { Console.Write("seventy"); if (units != 0) { Console.Write("-"); } getDigit(units); } break;
                case 8: { Console.Write("eighty"); if (units != 0) { Console.Write("-"); } getDigit(units); } break;
                case 9: { Console.Write("ninety"); if (units != 0) { Console.Write("-"); } getDigit(units); } break;
            }
        }
    }
}