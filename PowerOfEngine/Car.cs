using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfEngine
{
    class Car
    {
        private string model;
        private long speed;
        private long power;
        private long weight;
        private string type;
        private float push1;
        private long age1;
        private float push2;
        private long age2;
        private float push3;
        private long age3;
        private float push4;
        private long age4;

        public Car(string model, long speed, long power, long weight, string type, float push1, long age1, float push2, long age2, float push3, long age3, float push4, long age4)
        {
            this.model = model;
            this.speed = speed;
            this.power = power;
            this.weight = weight;
            this.type = type;
            this.push1 = push1;
            this.age1 = age1;
            this.push2 = push2;
            this.age2 = age2;
            this.push3 = push3;
            this.age3 = age3;
            this.push4 = push4;
            this.age4 = age4;
        }
    }
}


