using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduce
{
    class Person
    {
        private string name;
        private int age=16;

        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age {
            get { return this.age; }
            set { this.age = value; }
        }
        public void IntroduceYourself() {
            Console.WriteLine($"Your name is {name} and you are {age}-year old!!!!");
        }
    }
}
