using System;
using System.Collections.Generic;
using UniversityRules_day14_Interface_Project.Services;
using UniversityRules_day14_Interface_Project.Fuctionality;

namespace UniversityRules_day14_Interface_Project.UI
{
    internal class InspectionMain
    {
        public static void Main(string[] args)
        {
            IUniversityRules director = new Student();

            Console.WriteLine("\n\t\t.....WelCome To University Interface......\n\t\tThere Are Some Rules And Regulation(Contract) : Given By Director Which Have To Must Follow...");

            Console.WriteLine("\n\t\t................................Rules And Regulations.....................");
            // When Director Go through an University And Examine All Environment(Interface) Is Follow or Not :
            director.IdCard();
            director.Timings();
            director.BookSConsultation();
            director.Totalfess();

            Console.WriteLine("\n\t\t.........................................................................");

           // director.StudyLib(); //  Director Don't wanna Extra Activity doing by student
           
            // When we Create Object and access through that object now at that time Interface now lost and break

            Console.WriteLine("\n\n\tWhen we Create Object and access through that object now at that time Interface now lost and break");
            Student student = new Student();
            student.Timings(); 


            Console.ReadLine();
        }
    }
}
