using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Person name1 = new Person();
            Console.Write("Name ");
            name1.Name = Console.ReadLine();
            Console.Write("Years ");
            name1.Age = int.Parse(Console.ReadLine());
            BankAccount smetka1 = new BankAccount();
            Console.Write("ID");
            smetka1.ID = int.Parse(Console.ReadLine());
            Console.Write("Balance ");
            smetka1.Balance = double.Parse(Console.ReadLine());
            smetka1.Deposit(int.Parse(Console.ReadLine()));
            smetka1.WithDraw(int.Parse(Console.ReadLine()));
            name1.Account.Add(smetka1);
            name1.GetBalance();
            Person name2 = new Person();
            Console.Write("Name ");
            name2.Name = Console.ReadLine();
            Console.Write("Years ");
            name2.Age = int.Parse(Console.ReadLine());
            BankAccount smetka2 = new BankAccount();
            Console.Write("ID");
            smetka2.ID = int.Parse(Console.ReadLine());
            Console.Write("Balance ");
            smetka2.Balance = double.Parse(Console.ReadLine());
            smetka2.Deposit(int.Parse(Console.ReadLine()));
            smetka2.WithDraw(int.Parse(Console.ReadLine()));
            name2.Account.Add(smetka2);
            name2.GetBalance();
        }
    }
}
