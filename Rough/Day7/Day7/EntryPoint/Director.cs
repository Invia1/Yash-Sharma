using Day7.BLL;
using Day7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.EntryPoint
{
    class Director
    {
        static void Main(string[] args)
        {
            HR objHR = new HR();
            Employee temp = objHR.EmployeeDetails();
            Console.WriteLine(temp.EmpId + " " + temp.EmpName + " " + temp.EmpAge);
        }
    }
}
