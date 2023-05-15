using System.Collections.Generic;
using System;

namespace Day7_Generics
{
    class Data
    {
        List<string> ls = new List<string>();

        public void AddData()
        {
            Console.WriteLine("Enter Contact Name data");
            string str = Console.ReadLine();
            ls.Add(str);
        }
        public void RemoveData()
        {

            Console.WriteLine("\n\t\tPlease Enter options\n\t\t 1. Delete All data \n\t\t 2.Delete Specified Contact");
            int n = int.Parse(Console.ReadLine());
            if (n == 1) ls.Clear();
            else if (n == 2)
            {
                Console.WriteLine("\n\t\tWhich index of contact wanna delete...");
                foreach (var i in ls) { Console.WriteLine(i); }
                int a = int.Parse(Console.ReadLine());
                ls.RemoveAt(a);
                Console.WriteLine("\n\t\tSuccessfully deleted...");
            }
        }
        public void updateData()
        {
            int n = 0;
            Console.WriteLine("\n\t\tWhich index of contact wanna update...");
            foreach (var i in ls) { Console.WriteLine($"{n++}->{i}"); }
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\t\tEnter Contact Name...");
            string st = Console.ReadLine();
            ls[a] = st;
            return;
        }
        public void SearchData()
        {
            Console.WriteLine("Please Enter Contact Data want to Search");
            string str = Console.ReadLine();

            foreach (var i in ls)
            {
                if (i.Equals(str)) { Console.WriteLine("yes present"); return; }
            }
            Console.WriteLine("not Found"); Console.ReadLine();
        }
        public void ReadData()
        {
            foreach (var i in ls) { Console.WriteLine(i); }
            Console.ReadLine();
        }

    }


    internal class List
    {
        public static void Main()
        {

            void display()
            { 
                Console.WriteLine(" press 1. to Add Data");
                Console.WriteLine(" press 2. to Remove Data");
                Console.WriteLine(" press 3. to search Data");
                Console.WriteLine(" press 4. to fetch Data");
                Console.WriteLine(" press 5. to update Data");
                Console.WriteLine(" press 6. to to exit");
            }

            Data c1 = new Data();

            bool check = true;
            while (check)
            {
                display();
                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        c1.AddData();
                        break;
                    case 2:
                        c1.RemoveData();
                        break;
                    case 3:
                        c1.SearchData();
                        break;
                    case 4:
                        c1.ReadData();
                        break;
                    case 5:
                        c1.updateData();
                        break;
                    case 6: check = false; break;
                    default:
                        Console.WriteLine("wrong enter");
                        break;

                }

            }

        }
    }
}
