using System;
using System.Collections.Generic;
using Hospital_Management_System.Models;
using Hospital_Management_System.Services;

namespace Hospital_Management_System.Functionality
{
    internal interface IHospitalOperation
    {
        int createPatient(Patient p);
        List<Patient> getPatientList();
        void displayPatient();
        void registerPatient();
    }
}
