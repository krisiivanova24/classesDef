using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testClient
{
   public class Person
    {
        private string name;
        private int age = 16;
        List<BankAccount> account = new List<BankAccount>();
        List<Person> people = new List<Person>();

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
        public void IntroduceYourself()
        {
            Console.WriteLine($"Your name is {name} and you are {age}-year old!!!!");
        }
        public List<BankAccount> Account
        {
            get { return this.account; }
            set { this.account = value; }
        }
        public void GetBalance() {
            double suma = Account.Sum(e => e.Balance);
            Console.WriteLine($"The person: {this.Name} has balance:{suma} ");
            Console.WriteLine();

        }
    }
}
