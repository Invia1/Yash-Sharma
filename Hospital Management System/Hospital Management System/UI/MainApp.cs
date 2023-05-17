using System;
using System.Collections.Generic;
using Hospital_Management_System.Models;
using Hospital_Management_System.Services;

namespace Hospital_Management_System.UI
{
    class MainApp
    {
        public static void Main(string[] args)
        {

            void display()
            {
                Console.WriteLine("\n\t\tWelcome to Hospital");
                Console.WriteLine(" press 1. to Add Patient");
                Console.WriteLine(" press 2. to Display Pateint Details");
                Console.WriteLine(" press 3. to to exit");
            }
            HospitalServices c1 = new HospitalServices();
            bool check = true;
            while (check)
            {
                display();
                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        c1.registerPatient();
                        break;
                    case 2:
                        c1.displayPatient();
                        break;
                    case 3:
                        Console.WriteLine("Thank You for Visiting");
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}
