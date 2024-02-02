namespace IuliaTiaStoian_ClassesWithLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring and defining variables
            Candelabru candelabru1 = new Candelabru(60, 75, 100);
            Candelabru candelabru2 = new Candelabru(40, 60, 75, 75, 100);

            Dictionary<string, Candelabru> dictionary = new Dictionary<string, Candelabru>();

            dictionary.Add("Candelabrul 1", candelabru1);
            dictionary.Add("Candelabrul 2", candelabru2);

            // show chandeliers' state
            foreach (var candelabru in dictionary)
            {
                if (candelabru.Value.Aprins) { Console.WriteLine($"{candelabru.Key} este aprins."); }
                else { Console.WriteLine($"{candelabru.Key} este stins."); }
            }

            // show the maximum power of the chandeliers
            foreach (var candelabru in dictionary) { Console.WriteLine($"{candelabru.Key} are puterea maxima {candelabru.Value.PutereMaxima}."); }

            // turn on chandeliers
            foreach (var candelabru in dictionary) { candelabru.Value.Aprinde(); }

            // show chandeliers' state
            foreach (var candelabru in dictionary)
            {
                if (candelabru.Value.Aprins) { Console.WriteLine($"{candelabru.Key} este aprins."); }
                else { Console.WriteLine($"{candelabru.Key} este stins."); }
            }

            // show the current power of the chandeliers
            foreach (var candelabru in dictionary) { Console.WriteLine($"{candelabru.Key} are puterea curenta {candelabru.Value.PutereCurenta}."); }

            // turn off chandeliers
            foreach (var candelabru in dictionary) { candelabru.Value.Stinge(); }

            // show chandeliers' state
            foreach (var candelabru in dictionary)
            {
                if (candelabru.Value.Aprins) { Console.WriteLine($"{candelabru.Key} este aprins."); }
                else { Console.WriteLine($"{candelabru.Key} este stins."); }
            }

            // increase chandeliers' power with 80
            foreach (var candelabru in dictionary) { candelabru.Value.MaresteLumina(80); }

            // show chandeliers' state
            foreach (var candelabru in dictionary)
            {
                if (candelabru.Value.Aprins) { Console.WriteLine($"{candelabru.Key} este aprins."); }
                else { Console.WriteLine($"{candelabru.Key} este stins."); }
            }

            // show the current power of the chandeliers
            foreach (var candelabru in dictionary) { Console.WriteLine($"{candelabru.Key} are puterea curenta {candelabru.Value.PutereCurenta}."); }

            // decrease chandeliers' power with 50
            foreach (var candelabru in dictionary) { candelabru.Value.ReduceLumina(50); }

            // show chandeliers' state
            foreach (var candelabru in dictionary)
            {
                if (candelabru.Value.Aprins) { Console.WriteLine($"{candelabru.Key} este aprins."); }
                else { Console.WriteLine($"{candelabru.Key} este stins."); }
            }

            // show the current power of the chandeliers
            foreach (var candelabru in dictionary) { Console.WriteLine($"{candelabru.Key} are puterea curenta {candelabru.Value.PutereCurenta}."); }
        }
    }
}