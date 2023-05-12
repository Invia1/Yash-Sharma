using Day7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.BLL
{
    class HR
    {
        bool IsValid(string input)
        {
            int number = 0;
            return int.TryParse(input,out number);
        }
        public Employee EmployeeDetails()      //we will return Employee class SO that it will return all type of values string,int
        {
            Employee obj = new Employee();
            //obj.EmpId=int.Parse(Console.ReadLine());
            string n = Console.ReadLine();

            if (IsValid(n))
            {
                obj.EmpId = int.Parse(n);
            }

            //  obj.EmpId = 101;
            //while (true)
            //{
            //    obj.EmpName=Console.ReadLine();
            //    IsValid(obj.EmpName);
            //}

            obj.EmpName = "deepa";
            obj.EmpAge = 21;
            return obj;
        }
    }
}
