using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingCars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            List<string> cars = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                cars.Add(input);
            }
            List<string> com = new List<string>();
            string comm = Console.ReadLine();
            while (comm != "End")
            {

                comm = Console.ReadLine();

            }
        }
    }
}
