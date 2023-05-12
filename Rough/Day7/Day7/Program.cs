using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpAge { get; set; }
    }
    class HR
    {
        public Employee EmployeeDetails()      //we will return Employee class SO that it will return all type of values string,int
        {
            Employee obj=new Employee();
            obj.EmpId = 101;
            obj.EmpName = "deepa";
            obj.EmpAge = 21;
            return obj;
        }
    }
    class Director
    {
        static void Main(string[] args)
        {
            HR objHR = new HR();
            Employee temp=objHR.EmployeeDetails();
            Console.WriteLine(temp.EmpId+" "+temp.EmpName+" "+temp.EmpAge);
        }
    }
    
}
