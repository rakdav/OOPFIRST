using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOPFIRST
{
    class Program
    {
        static void Main(string[] args)
        {
            string f = Console.ReadLine();
            string name = Console.ReadLine();
            string otch = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            //Person person1 = new Person(f,name,otch);

            //string newName = Console.ReadLine();
            //for(int i=0;i<=80;i++)
            //{
            //    Console.WriteLine(person1.Print());
            //    if (i==23) person1.setFirstName(newName);
            //    person1.changeAge();
            //    person1.changeWeight();
            //    Thread.Sleep(2000);
            //}
            SuperPerson sp = new SuperPerson(f, name, otch, age, weight);
            string newName = Console.ReadLine();
            for (int i = 0; i <= 80; i++)
            {
                Console.WriteLine(sp.FirstName+" "+sp.Surname+" "+sp.MiddleName+" "+sp.Age+" "+sp.Weight);
                if (i == 23) sp.FirstName=newName;
                sp.Age++;
                if (sp.Age % 2 == 0) sp.Weight += 3;
                else sp.Weight -= 0.5;
                Thread.Sleep(1000);
            }
            Console.ReadKey();
        }
    }
}
