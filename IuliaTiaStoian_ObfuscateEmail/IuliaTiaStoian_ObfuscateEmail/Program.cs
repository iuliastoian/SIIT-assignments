namespace IuliaTiaStoian_ObfuscateEmail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare and define input
             string? input = Console.ReadLine();

            if (input == null) { Console.WriteLine("Input must not be empty. Type an email address as input."); return; }

            string substring = input.Split('@')[0];
            string obfuscate = new String('*', substring.Length);
            input = input.Replace(substring, obfuscate);

            Console.WriteLine(input);
        }
    }
}