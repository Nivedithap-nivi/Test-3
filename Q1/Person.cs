using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
   public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public Person(string name, string address, int age)
        {
            this.Name = name;
            this.Address = address;
            this.Age = age;
        }
    }

    public class PersonImplementation
    {
        public string GetName(IList<Person> person)
        {
            string name = "";
            foreach (var p in person)
            {
                name += $"{p.Name} {p.Address}\n";
            }
            return name;
        }
        public double Average(IList<Person> person)
        {
            int avg = 0;
            foreach (var p in person)
            {
                avg += p.Age;
            }
            return (double)avg / person.Count;
        }
        public int Max(IList<Person> people)
        {
            int max = 0;
            foreach (var p in people)
            {
                if (p.Age > max)
                {
                    max = p.Age;
                }
            }
            return max;
        }
    }
}