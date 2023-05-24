using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityRules_day14_Interface_Project.Fuctionality;

namespace UniversityRules_day14_Interface_Project.Services
{
    internal class Student: IUniversityRules // This is a Servies Class Used To Implement to Abstract Method Which are Declare in Interface Named as : "IUniversityRules" :
    {

        // properties........
        public string Name { get; set; } 
        public int Age { get; set; }

        // Other Extra Activity....
        public void StudyLib()
        {
            Console.WriteLine("Student Study In Library...");
        }
        public void CricketMatch()
        {
            Console.WriteLine("Student Play Cricket Match...");
        }

        // Abstract Functions Definining and Provdide Body of Implementaion :
        public void IdCard() { Console.WriteLine("\n\t\tStudent Must Have Id Card to Enter In Collage :"); }
        public void Timings() { Console.WriteLine("\t\tStudent Must Enter In Collage Sharp 9 O'Clock :"); }
        public void Totalfess() { Console.WriteLine("\t\tStudent Must Have Clear their All dues :"); }
        public void BookSConsultation() { Console.WriteLine("\t\tStudent Must Have clear all Consultancy After Ends the semester :"); }

    }
}
