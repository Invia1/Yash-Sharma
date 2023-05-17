using System;
using Hospital_Management_System.Models;
using System.Collections.Generic;
using Hospital_Management_System.Functionality;


namespace Hospital_Management_System.Services
{
    class HospitalServices
    {
        
        List<Patient> patList=new List<Patient>();
       
        public List<Patient> getPatientList()
        {
            return patList;
        }
        public void displayPatient()
        {
            foreach (var p1 in patList)
            {
                Console.WriteLine("Registration Id:" + " " + p1.PatRegistrationId);
                Console.WriteLine("First Name:" + " " + p1.PatFirstName);
                Console.WriteLine("Last Name:" + " " + p1.PatLastName);
                Console.WriteLine("Phone No" + " " + p1.PhoneNo);
                Console.WriteLine("Gender:" + " " + p1.Gender);
                Console.WriteLine("Age:" + " " + p1.PatAge);
                Console.WriteLine("Address:" + " " + p1.PatAddress);
                Console.WriteLine("Aadhar No:" + " " + p1.AadharNo);
                return;
            }

        }
        public void registerPatient()
        {
            Patient p1 = new Patient();
            Console.WriteLine("Enter Registration Number");
            int id=int.Parse(Console.ReadLine());   
            if (IsDuplicateRegistrationId(id))
            {
                Console.WriteLine("Registration id already exist with another Patient");
                return;
            }
            p1.PatRegistrationId = id;
            Console.WriteLine("Enter First Name:");
            p1.PatFirstName=Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            p1.PatLastName = Console.ReadLine();
            Console.WriteLine("Enter Phone No:");
            p1.PhoneNo = Console.ReadLine();
            Console.WriteLine("Enter Gender:");
            p1.Gender = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            p1.PatAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Address:");
            p1.PatAddress=Console.ReadLine();
            Console.WriteLine("Enter Aadhar No:");
            string aadharNo = Console.ReadLine();
            if (IsDuplicatePatient(aadharNo))
            {
                Console.WriteLine("Aadhar Card already exist with another Patient");
                return;
            }
            p1.AadharNo=aadharNo;
            Console.WriteLine("Please enter Speciality to Consult");
            Console.WriteLine("Select 1 for General Medicine");
            Console.WriteLine("Select 2 for Orthopedics");
            Console.WriteLine("Select 3 for Dental");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine(p1.SpecialityToConsult = "General Medicine");
                    break;
                case 2:
                    Console.WriteLine(p1.SpecialityToConsult = "Orthopedics");
                    break;
                case 3:
                    Console.WriteLine(p1.SpecialityToConsult = "Dental");
                    break;
                default:
                    Console.WriteLine("Sorry this Speciality is not present");
                    break;
            }
            patList.Add(p1);

        }
        public bool IsDuplicatePatient(string aadharNo)
        {
            foreach (Patient obj in patList)
            {
                if (obj.AadharNo == aadharNo)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsDuplicateRegistrationId(int id)
        {
            foreach (Patient obj in patList)
            {
                if (obj.PatRegistrationId == id)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
