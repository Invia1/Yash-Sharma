using Day7Prac.Model;
using Day7Prac.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Prac.EntryPoint
{
    class Customer
    {
        static void Main(String[] args)
        {
            Waiter obj=new Waiter();
            Menu temp=obj.FoodDetails();
            Console.WriteLine("Food Name \tFood Price");
            Console.WriteLine(temp.Name + "\t" + temp.Price);
            Console.ReadLine();
        }
    }
}
