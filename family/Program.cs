using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            List<Person> human2 = new List<Person>();
            Person human = new Person();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                human = new Person();
                
                human.Name = input[0];
                human.Age = int.Parse(input[1]);
                human2.Add(human);     
                
                

            }
            //Console.WriteLine("yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy");
             human2 = human2.OrderBy(x => x.Name).ToList();
                for (int i = 0; i < human2.Count; i++)
                {
                    Console.WriteLine($"{human2[i].Name} {human2[i].Age}");
                }
            
            
        }
    }
}
