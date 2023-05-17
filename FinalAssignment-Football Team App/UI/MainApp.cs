using System;
using System.Collections.Generic;
using FootballTeamApp.Models;
using FootballTeamApp.Services;
using FootballTeamApp.Functionality;

namespace FootballTeamApp.UI
{
    class MainApp
    {
        public static void Main(string[] args)
        {


                void display()
                {
                    Console.WriteLine("\n\t\tWelcome to List<string> operations");
                    Console.WriteLine(" press 1. to Add PLayer");
                    Console.WriteLine(" press 2. to Remove Player");
                    Console.WriteLine(" press 3. to search Player");
                    Console.WriteLine(" press 4. to fetch Player");
                    Console.WriteLine(" press 5. to update Player");
                    Console.WriteLine(" press 6. to to exit");
                }

                IFootballOperation c1 = new FootballServices();

                bool check = true;
                while (check)
                {
                    display();
                    int n = int.Parse(Console.ReadLine());

                    switch (n)
                    {
                        case 1:
                            c1.AddPlayer();
                            break;
                        case 2:
                            c1.RemovePlayer();
                            break;
                        case 3:
                            c1.SearchPlayer();
                            break;
                        case 4:
                            c1.ReadPlayer();
                            break;
                        case 5:
                            c1.updatePlayer();
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
