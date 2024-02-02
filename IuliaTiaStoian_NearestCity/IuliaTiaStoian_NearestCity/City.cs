using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IuliaTiaStoian_NearestCity
{
    internal class City
    {
        private string _name;
        private Coordinates _coordinates;

        public string Name { get { return _name; } }

        public Coordinates Coordinates
        {
            get { return _coordinates; }
            set
            {
                if (value.X < Coordinates.MIN ||
                    value.Y < Coordinates.MIN ||
                    value.X > Coordinates.MAX ||
                    value.Y > Coordinates.MAX)
                { throw new ArgumentOutOfRangeException($"Coordinates must be in the range [{Coordinates.MIN}-{Coordinates.MAX}]"); }
                else { _coordinates = value; }
            }
        }

        public string Info { get { return "City \"" + _name + "\" with coordinates " + Coordinates.Info; } }

        public City(string name, Coordinates coordinates)
        {
            _name = name;
            Coordinates = coordinates;
        }
    }
}
