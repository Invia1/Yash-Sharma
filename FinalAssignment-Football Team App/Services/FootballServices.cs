using System;
using System.Collections.Generic;
using FootballTeamApp.Functionality;
using FootballTeamApp.Models;

namespace FootballTeamApp.Services
{
    class FootballServices:IFootballOperation
    {
        List<Football> objList = new List<Football>();
        public int CreateFootballPlayer(Football pl)
        {
            objList.Add(pl);
            return objList.Count;
        }
        public List<Football> GetAllFootballs() {
            return objList;
        }
        public void updatePlayer()
        {
            Console.WriteLine("\n\t\tPlease enter Player Number to Update...");
            int id = int.Parse(Console.ReadLine());

            foreach (var i in objList)
            {
                if (i.PlayerNumber == id)
                {
                    Console.WriteLine("\n\t\tPlease enter Player Number");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("\t\tplease enter Player Name");
                    string n1 = Console.ReadLine();
                    Console.WriteLine("\t\tplease enter Player Age");
                    int n2 = int.Parse(Console.ReadLine());

                    i.PlayerNumber = n;
                    i.PlayerName = n1;
                    i.Age = n2;

                    Console.WriteLine("\n\t\tCongratulations !! Data Successfully Updated...");
                }
            }
            Console.WriteLine("Number is Not present ");
        }
        public void RemovePlayer()
        {
            Console.WriteLine("\n\t\tplease enter Player Number to delete...");
            int id = int.Parse(Console.ReadLine());

            foreach (var i in objList)
            {
                if (i.PlayerNumber == id)
                {
                    objList.Remove(i);
                    Console.WriteLine("\n\t\tdata is Deleted"); return;
                }
            }
            Console.WriteLine("\n\t\tNumber is Not present.... ");

        }

        // Add data
        public void AddPlayer()
        {
            Console.WriteLine("\n\t\tPlease give some details of Player....");
            Console.Write("\n\t\tplease enter Player Name-");
            string n = Console.ReadLine();
            Console.Write("\t\tplease enter Player Number-");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("\t\tplease enter PLayer Age-");
            int n2 = int.Parse(Console.ReadLine());

            objList.Add(new Football(n, n1, n2));

            Console.WriteLine("\n\t\tCongratulations !! Data Successfully Added...");

            Console.WriteLine("\n\t\t ....Want to Add more Data Press 1\t else press 2...");

            int n3 = int.Parse(Console.ReadLine());

            if (n3 == 2) return;
            else if (n3 == 1) { AddPlayer(); }
            else { Console.WriteLine("\t\tWorng Number pressing..."); }
        }
        public void SearchPlayer()
        {
            Console.WriteLine("\n\t\tPlease Enter Player Number");
            int id = int.Parse(Console.ReadLine());
            foreach (var i in objList)
            {
                if (i.PlayerNumber == id) Console.WriteLine("\n\t\tYes data is Present....");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("\n\t\tPlayer Number is Not present.... ");
            Console.ReadLine();
        }

        // fetch All data
        public void ReadPlayer()
        {
            Console.WriteLine("\n\t\tName | Number  | age ");
            foreach (Football e in objList)
            {
                Console.WriteLine("\n\t\t" + e.PlayerName + "  | " + e.PlayerNumber + "  | " + e.Age);
            }
            Console.ReadLine();
        }
    }
}
