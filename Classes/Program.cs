using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        public class Person
        {
            public string Name;

            public void Introduce()
            {
                Console.WriteLine($"Hello, I am {Name}");
            }
            
        }
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Vishal";
            var person = new Person
            {
                Name = "Vishal"
            };
            person.Introduce();


        }
    }
}
