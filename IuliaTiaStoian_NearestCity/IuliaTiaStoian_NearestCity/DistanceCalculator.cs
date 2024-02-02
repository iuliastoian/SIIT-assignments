using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IuliaTiaStoian_NearestCity
{
    static class DistanceCalculator
    {
        public static double ComputeDistance(City city1, City city2)
        {
            return Math.Sqrt(Math.Pow(city1.Coordinates.X - city2.Coordinates.X, 2) + Math.Pow(city1.Coordinates.Y - city2.Coordinates.Y, 2));
        }
    }
}
