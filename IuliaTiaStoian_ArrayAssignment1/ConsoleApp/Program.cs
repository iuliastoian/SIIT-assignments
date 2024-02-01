namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** Read the dimension of an array of integers from the console and then read the elements of that array also from the console. 
             *   Calculate and display the min and the max of the array elements. 
             */

            Console.Write("Input array size: ");
            int size = GetValidInput("array size");

            int[] array = new int[size];

            int min = Int32.MaxValue;
            int max = Int32.MinValue;

            Console.WriteLine("\nInput array elements:");
            for (int i = 0; i < size; ++i)
            {
                Console.Write($"array[{i}] = ");
                array[i] = GetValidInput($"array[{i}]");

                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }

            Console.WriteLine("Minimum value from array is " + min);
            Console.WriteLine("Maximum value from array is " + max);
        }

        static int GetValidInput(string identificator)
        {
            int validInput;
            while (true)
            {
                try
                {
                    validInput = Convert.ToInt32(Console.ReadLine());

                    if (identificator == "array size" && validInput <= 0)
                    {
                        Console.WriteLine($"Invalid input. {identificator} must be greater than 0.");
                        Console.Write($"\nInput {identificator} : ");
                        continue;
                    }

                    break;
                }
                catch
                {
                    Console.WriteLine($"Invalid input. {identificator} must be an integer.\n");
                    Console.Write($"{identificator} = ");
                }
            }

            return validInput;
        }
    }
}