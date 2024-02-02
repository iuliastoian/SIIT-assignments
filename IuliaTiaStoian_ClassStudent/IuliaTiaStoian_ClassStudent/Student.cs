using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IuliaTiaStoian_ClassStudent
{
    internal class Student
    {
        public string name;
        private byte age;

        public const byte MIN_AGE = 18;
        public const byte MAX_AGE = 99;

        public byte Age
        {
            get { return age; }
            set
            {
                if (value < MIN_AGE || value > MAX_AGE) { throw new ArgumentOutOfRangeException(); }
                else { age = value; }
            }
        }

        public byte? Mark { get; set; }

        public dynamic Info { get { return "Student's name is " + name + " and is " + age.ToString() + " years old."; } }

        public Student(string name, byte age)
        {
            this.name = name;
            Age = age;
        }
    }
}
