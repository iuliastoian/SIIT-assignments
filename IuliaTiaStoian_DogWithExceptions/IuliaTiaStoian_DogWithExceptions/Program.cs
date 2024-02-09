namespace IuliaTiaStoian_DogWithExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // negative age
            try
            {
                Dog dog = new Dog(-5, "Rex");
            }
            catch (ApplicationException ex) { Console.WriteLine(ex.Message); }

            // age greater than 100
            try
            {
                Dog dog = new Dog(101, "Rex");
            }
            catch (ApplicationException ex) { Console.WriteLine(ex.Message); }

            // name contains less than 2 characters
            try
            {
                Dog dog = new Dog(2, "R");
            }
            catch (ApplicationException ex) { Console.WriteLine(ex.Message); }
        }
    }
}