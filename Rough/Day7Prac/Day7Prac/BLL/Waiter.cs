using Day7Prac.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Prac.BLL
{
    public class Waiter
    {
        public Menu FoodDetails()
        {
            Menu dish = new Menu();
            Console.WriteLine("Enter dish name");
            string n=Console.ReadLine();
            dish.Name = n;
            Console.WriteLine("Enter dish price");
            int pri = int.Parse(Console.ReadLine());
            dish.Price=pri;
            return dish;
        }
    }
}
