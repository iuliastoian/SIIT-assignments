using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IuliaTiaStoian_NearestCity
{
    internal class Coordinates
    {
        private byte _x;
        private byte _y;

        public const byte MAX = 10;
        public const byte MIN = 0;

        public byte X { get { return _x; } set { _x = value; } }
        public byte Y { get { return _y; } set { _y = value; } }

        public string Info { get { return "(" + X + ", " + Y + ")"; } }

        public Coordinates(byte x, byte y)
        {
            X = x;
            Y = y;
        }
    }
}
