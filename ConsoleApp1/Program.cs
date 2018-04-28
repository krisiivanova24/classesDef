using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testClient;

namespace statistic
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 1; i <= n; i++)
            {
                Person newO = new Person();
                string[] input = Console.ReadLine().Split().ToArray();
                if (int.Parse(input[1]) > 30)
                {
                    newO.Name = input[0];
                    newO.Age = int.Parse(input[1]);
                    people.Add(newO);
                }

            }
            people = people.OrderBy(c => c.Name).ToList();
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine($"{people[i].Name} - {people[i].Age}");
            }
        }
    }
}
