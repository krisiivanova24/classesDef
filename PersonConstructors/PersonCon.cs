using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonConstructors
{
    public class PersonCon
    {
        private string name;
        private byte age;
        public PersonCon(string name, byte age) {
            this.name = name;
            this.age = age;
        }
        public PersonCon(byte age) {
            this.name = "No name";
            this.age = age;
        }
        public PersonCon() {
            this.name = "No name";
            this.age = 1;
        } 
        public void Print() {
            Console.WriteLine($"{name} {age}");
        }

    }
}
