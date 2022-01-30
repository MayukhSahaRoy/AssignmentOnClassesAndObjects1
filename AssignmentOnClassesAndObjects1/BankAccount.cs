using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnClassesAndObjects1
{
    class BankAccount
    {
        public string depositor_name;
        public string account_no;
        public string account_type;
        public double balance;

        public void initialise()
        {
            Console.WriteLine("Enter the name of the depositor:");
            depositor_name = Console.ReadLine();
            Console.WriteLine("Enter the account number:");
            account_no = Console.ReadLine();
            Console.WriteLine("Enter the type of account:");
            account_type = Console.ReadLine();
            Console.WriteLine("Enter the balance amount in the account:");
            balance = double.Parse(Console.ReadLine());
        }

        public void deposit(double amount)
        {
            balance = balance + amount;
        }
        
        public void withdraw(double amount)
        {
            if (balance < amount)
                Console.WriteLine("Withdrawal not possible, not enough money left");
            else
                balance = balance - amount;
        }

        public void display()
        {
            Console.WriteLine("The name of the depositor is: " + depositor_name);
            Console.WriteLine("The balance is: " + balance);
        }
    }

    class BankAccount_test
    {
        static void Main()
        {
            BankAccount p1 = new BankAccount();
            double amount;
            p1.initialise();
            for(; ; )
            {
                Console.WriteLine("Enter D for deposit and W for withdraw:");
                char ch = char.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 'D':
                        Console.WriteLine("Enter the amount to be deposited:");
                        amount = double.Parse(Console.ReadLine());
                        p1.deposit(amount);
                        p1.display();
                        break;
                    case 'W':
                        Console.WriteLine("Enter the amount to be withdrawed:");
                        amount = double.Parse(Console.ReadLine());
                        p1.withdraw(amount);
                        p1.display();
                        break;
                    default:
                        Console.WriteLine("Incorrect Choice");
                        break;
                }
                Console.WriteLine("if you don't want to continue press 1");
                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                    break;
            }
            Console.ReadKey();
        }
    }
}
