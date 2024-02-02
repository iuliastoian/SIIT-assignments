namespace IuliaTiaStoian_SearchForNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started... Input number to find (Press CTRL + C to stop the program when finished testing)");
            
            while (true)
            {
                int[] randomNo = {
            42, 18, 67, 91, 55, 23, 78, 14, 36, 81,
            29, 50, 62, 17, 95, 10, 45, 73, 26, 59,
            37, 88, 12, 68, 31, 74, 19, 53, 82, 44,
            65, 27, 96, 11, 49, 71, 34, 77, 22, 58,
            83, 38, 69, 16, 93, 8,  41, 66, 30, 75,
            20, 52, 87, 15, 54, 76, 39, 64, 21, 94,
            9,  46, 72, 28, 61, 13, 80, 48, 35, 70,
            24, 57, 86, 33, 79, 6,  43, 89, 25, 56,
            98, 32, 63, 7,  92, 5,  40, 85, 3,  60,
            47, 84, 4,  99, 2,  74, 16, 31, 53, 97
            };

                if (!int.TryParse(Console.ReadLine(), out int input)) { Console.WriteLine("Invalid input. Enter an integer number."); return; }

                bool found = false;
                byte index = 255;
                for (int i = 0; i < randomNo.Length; ++i)
                {
                    if (randomNo[i] == input) { found = true; index = (byte)i; break; }
                }

                if (found) { Console.WriteLine($"{input} was found at index {index} in the random numbers array."); }
                else { Console.WriteLine($"{input} was not found int the random numbers array."); }
            }
        }
    }
}