using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day5AssignmentNo3
{
    class Person
    {
        BankDetails det=new BankDetails();
        int accountBalance;
        string name;
        public int AccountBalance
        {
            get
            {
                return accountBalance;
               
            }
            set
            {
                accountBalance = value;
                if (accountBalance < 10000)
                {
                    det.cancelShopping();
                }
                else
                {
                    det.readyShopping();
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class BankDetails
    {
        public void readyShopping()
        {
            Console.WriteLine("Ready for shopping enough amount in bank");
        }
        public void cancelShopping()
        {
            Console.WriteLine("Cancel shopping less than 10000 in account");
        }

        // public member function
        public void personDetails() {
            Person p = new Person();
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            p.Name = name;
            Console.WriteLine("Enter the amount in your bank");
            int account=int.Parse(Console.ReadLine());
            p.AccountBalance = account;
        }
    }
    class Shopping
    {
        public static void Main(string[] args)
        {
            BankDetails bank=new BankDetails();
            bank.personDetails();
            Console.ReadLine();

        }  
    }
}
