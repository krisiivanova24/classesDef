using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            byte times = byte.Parse(Console.ReadLine());
            string[] massive = new string[times];
            for (int i = 0; i < times; i++)
            {
                string firstLine = Console.ReadLine();
                massive[i] = firstLine;
            }
            string comm = Console.ReadLine();
            List<string> outLine = new List<string>();
            for (int i = 0; i < times; i++)
            {
                string[] input = massive[i].Split().ToArray();
                Car theCar = new Car(input[0], long.Parse(input[1]), long.Parse(input[2]), long.Parse(input[3]), input[4], float.Parse(input[5]), long.Parse(input[6]),float.Parse( input[7]), long.Parse(input[8]), float.Parse(input[9]), long.Parse(input[10]), float.Parse(input[11]), long.Parse(input[12]));
                if (String.Equals(comm, input[4]) && (String.Equals(comm, "fragile")))
                {
                    if (float.Parse(input[5]) < 1)
                    {
                        outLine.Add(input[0]);
                    }
                }
                else
                {
                    if (String.Equals(comm, input[4]) && (String.Equals(comm, "flamable")))
                    {
                        if (long.Parse(input[2]) > 250)
                        {
                            outLine.Add(input[0]);
                        }
                    }
                }
            }
            foreach (var item in outLine)
            {
                Console.WriteLine(item);
            }
        }
    }
}
