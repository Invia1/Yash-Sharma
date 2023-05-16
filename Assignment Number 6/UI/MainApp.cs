using Day9Prac.Model;
using Day9Prac.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Day9Prac.UI
{
    internal class MainApp
    {
        public static void Main(string[] args)
        {
            bool cond = true;
            while (cond)
            {
                Console.WriteLine("Welcome to Friend Details");
                Console.WriteLine("Please enter Friend Id");
                int fid = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter Friend Name");
                string fname = Console.ReadLine();
                Console.WriteLine("Please enter Friend Age");
                int age = int.Parse(Console.ReadLine());
                Friend obj1 = new Friend();
                obj1.FriendId = fid;
                obj1.FriendName = fname;
                obj1.FriendAge = age;
                FriendService fr = new FriendService();
                fr.createFriends(obj1);
                Console.WriteLine("Enter 1 for Add more Friends in list");
                Console.WriteLine("Enter 2 to perform operations");
                Console.WriteLine("Enter 3 to exit");
                int opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        break;
                    case 2:
                        bool cond2 = true;
                        while (cond2)
                        {
                            Console.WriteLine("Press 1 for Delete Friends");
                            Console.WriteLine("Press 2 for Search Friends");
                            Console.WriteLine("Press 3 for Update Friends");
                            Console.WriteLine("Press 4 for Display Friends");
                            Console.WriteLine("Press 5 for exit");
                            int opt2 = int.Parse(Console.ReadLine());
                            switch (opt2)
                            {
                                case 1:
                                    Console.WriteLine("Please give the Id to delete");
                                    int id = int.Parse(Console.ReadLine());
                                    fr.DeleteFriends(id);
                                    break;
                                case 2:
                                    Console.WriteLine("Please enter the name to search");
                                    string n = Console.ReadLine();
                                    fr.SearchFriend(n);
                                    break;
                                case 3:
                                    Console.WriteLine("Please enter the name to update");
                                    string na = Console.ReadLine();
                                    Console.WriteLine("Please enter the new name");
                                    string nam = Console.ReadLine();
                                    break;
                                case 4:
                                    fr.displayFriends();
                                    break;
                                case 5:
                                    cond2 = false;
                                    break;
                                default:
                                    Console.WriteLine("Not a valid Input");
                                    break;
                            }
                        }
                        break;
                    case 3:
                        cond = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid Input");
                        break;


                }
            }
            Console.ReadLine();

        }
    }
}
