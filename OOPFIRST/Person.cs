using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFIRST
{
    class Person
    {
        private string Firstname;
        private string Surname;
        private string MiddleName;
        private int Age;
        private double weight;

        public Person(string f,string s,string m, int age=0, double weight=3.5)
        {
            Firstname= f;
            Surname = s;
            MiddleName = m;
            Age = age;
            this.weight = weight;
        }
        public string Print()
        {
            return Firstname+" "+Surname+" "+MiddleName+" "+Age+" "+weight;
        }

        public int getAge()
        {
            return Age;
        }

        public double getWeight()
        {
            return weight;
        }

        public void setFirstName(string f)
        {
            Firstname = f;
        }
        public void changeAge()
        {
            Age++;
        }

        public void changeWeight()
        {
            if (Age % 2 == 0) weight += 3;
            else weight-=0.5;
        }
    }
}
