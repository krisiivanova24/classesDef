﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family
{
    class Person
    {
        private string name;
        private int age;
        List<Person> all = new List<Person>();

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        
        
    }
}
