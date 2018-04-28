using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testClient
{
   public class BankAccount
    {
        int id;
        double balance;
       
         public int ID {
            get { return this.id; }
            set { this.id = value; }
        }
        public double Balance {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public void Deposit(int sum) {
            this.balance += sum;
        }
        public void WithDraw(int sum) {
            this.balance -= sum;
        }
        
    }
}
