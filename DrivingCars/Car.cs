using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingCars
{
    class Car
    {
        private string name;
        private float engine;
        private float razhod;

        public Car(string name, float engine, float razhod) {
            this.name = name;
            this.engine = engine;
            this.razhod = razhod;
        }
        public float Drive(string name, byte km) {
            float po = this.razhod * km;
            if (engine < po)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.engine -= po;
            }
        }
    }
}
