using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFIRST
{
    class SuperPerson
    {
        public string FirstName { get; set; }
        public string Surname { get; }
        public string MiddleName { get; }
        public int Age { get; set; }
        public double Weight { get; set; }

        public SuperPerson(string firstName, string surname, string middleName, int age, double weight)
        {
            FirstName = firstName;
            Surname = surname;
            MiddleName = middleName;
            Age = age;
            Weight = weight;
        }
    }
}
