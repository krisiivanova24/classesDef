using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            PersonCon person = new PersonCon();
            person.Print();
            person = new PersonCon(byte.Parse(input[1]));
            person.Print();            
            person = new PersonCon(input[0], byte.Parse(input[1]));
            person.Print();


           
        }
    }
}
