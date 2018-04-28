using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount new1 = new BankAccount();
            new1.ID = int.Parse(Console.ReadLine());
            new1.Balance = double.Parse(Console.ReadLine());
            new1.Deposit(int.Parse(Console.ReadLine()));
            new1.WithDraw(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Account {new1.ID}, balance {new1.Balance}");
        }
    }
}
