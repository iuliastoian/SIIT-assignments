using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IuliaTiaStoian_DogWithExceptions
{
    internal class Dog
    {
        int _age;
        string _name;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0) throw new ApplicationException("The age cannot be a negative number.");
                if (value > 100) throw new ApplicationException("The age cannot be greater than 100.");
                _age = value;
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if ((value.Length < 2)) throw new ApplicationException("The name must contain at least 2 characters.");
                _name = value;
            }
        }

        public Dog(int age, string name)
        {
            Age = age;
            Name = name;
        }

    }
}
