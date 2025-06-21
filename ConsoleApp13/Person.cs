using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Person
    {
       public string Name { get; set; }
        public int Age { get; set; }
        public void Show()
        {
            Console.WriteLine($"My name is {Name}. I am {Age} years old.");
        }
    }
}
