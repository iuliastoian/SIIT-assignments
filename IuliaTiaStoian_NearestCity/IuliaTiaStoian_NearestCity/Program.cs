namespace IuliaTiaStoian_NearestCity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City cluj = new City("Cluj", new Coordinates(2, 3));
            City huedin = new City("Huedin", new Coordinates(4, 8));
            City dej = new City("Dej", new Coordinates(5, 2));
            City oradea = new City("Oradea", new Coordinates(7, 9));
            City timisoara = new City("Timisoara", new Coordinates(6, 8));

            Dictionary<string, City> map = new Dictionary<string, City>();
            map.Add(cluj.Name, cluj);
            map.Add(huedin.Name, huedin);
            map.Add(dej.Name, dej);
            map.Add(oradea.Name, oradea);
            map.Add(timisoara.Name, timisoara);

            foreach (var city in map) { Console.WriteLine(city.Value.Info); }

            Console.WriteLine("\nCalculator started. Press CTRL + C to stop the program when finished testing.\n");
            while (true)
            {
                Console.WriteLine("Find the nearest city to...? (Type the name of the city)");
                string? inputCityName = Console.ReadLine();

                if (!map.TryGetValue(inputCityName, out City inputCity)) { Console.WriteLine("This city is not part of the map. Skipping..."); }
                else
                {
                    double minDistance = Double.PositiveInfinity;
                    City minCity = inputCity;
                    foreach (var city in map)
                    {
                        if (city.Key == inputCityName) { continue; }

                        double distance = DistanceCalculator.ComputeDistance(inputCity, city.Value);
                        Console.WriteLine($"Distance from {inputCity.Name} to {city.Value.Name} is: " + distance);

                        if (distance < minDistance) { Console.WriteLine($"im here"); minDistance = distance; minCity = city.Value; }
                    }
                    Console.WriteLine($"\nResult => {minCity.Name} is the closest to {inputCityName}");
                }
            }
        }
    }
}