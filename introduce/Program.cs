using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduce
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstOne = new Person();
            firstOne.Name = "Mimi";
            firstOne.Age = 15;
            firstOne.IntroduceYourself();

            Person secondOne = new Person();
            secondOne.Name = Console.ReadLine();
           // secondOne.Age = int.Parse(Console.ReadLine());
            secondOne.IntroduceYourself();
        }
    }
}
