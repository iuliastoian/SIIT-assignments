namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# to find the element with the maximum and minimum length in an array of strings. */

            string[] arrayOfStrings = {
                "The cat jumps.",
                "A bird sings with joy.",
                "The sun sleeps through the night.",
                "A dog runs in the garden.",
                "My friend flies in the sky.",
                "A bird jumps under the tree.",
                "The cat sleeps in the garden.",
                "The sun runs through the night.",
                "A dog jumps with joy.",
                "My friend sings under the tree.",
            };

            int min, max, minIndex, maxIndex;

            min = max = arrayOfStrings[0].Length;
            minIndex = maxIndex = 0;

            for (int i = 1; i < 10; ++i)
            {
                if (arrayOfStrings[i].Length < min) { min = arrayOfStrings[i].Length; minIndex = i; }
                if (arrayOfStrings[i].Length > max) { max = arrayOfStrings[i].Length; maxIndex = i; }
            }

            Console.WriteLine($"Shortest string from array is element {minIndex}: \"" + arrayOfStrings[minIndex] + "\"");
            Console.WriteLine($"Longest string from array is element {maxIndex}: \"" + arrayOfStrings[maxIndex] + "\"");
        }
    }
}