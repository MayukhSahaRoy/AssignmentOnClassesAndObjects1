using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnClassesAndObjects1
{
    class Accounts
    {
        public string account_no;
        public string customer_name;
        public string account_type;
        public char transaction_type;
        public int amount;
        public int balance=0;

        public void accept()
        {
            Console.WriteLine("Enter the information details: ");
            Console.WriteLine("Enter the account number:");
            account_no = Console.ReadLine();
            Console.WriteLine("Enter the customer name:");
            customer_name = Console.ReadLine();
            Console.WriteLine("Enter the account type:");
            account_type = Console.ReadLine();
        }
        
        public void credit(int amount)
        {
            balance = balance + amount;
        }

        public void debit(int amount)
        {
            balance = balance - amount;
        }

        public void show_data()
        {
            Console.WriteLine("The Account number is: " + account_no);
            Console.WriteLine("The Customer name is: " + customer_name);
            Console.WriteLine("The Account type is: " + account_type);
            Console.WriteLine("The Balance is: " + balance);
        }
    }

    class Test_Account
    {
        static void Main()
        {
            Accounts s1 = new Accounts();
            s1.accept();
            for(; ; )
            {
                Console.WriteLine("Enter 'D' for deposit, 'W' for withdraw");
                Console.WriteLine("Enter your choice:");
                string ch = Console.ReadLine();
                switch(ch)
                {
                    case "D":
                        Console.WriteLine("Enter the amount to be deposited:");
                        s1.amount = int.Parse(Console.ReadLine());
                        s1.credit(s1.amount);
                        break;
                    case "W":
                        Console.WriteLine("Enter the amount to be withdrawed:");
                        s1.amount = int.Parse(Console.ReadLine());
                        s1.debit(s1.amount);
                        break;
                    default:
                        Console.WriteLine("Wrong Choice:");
                        break;
                }
                s1.show_data();
                Console.WriteLine("If you want to exit press 1:");
                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                    break;
            }
            Console.ReadKey();
        }
    }
}
