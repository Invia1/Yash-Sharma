using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test1Practise
{
    internal class Variable
    {
        readonly int empId;
        string name;
        double salary;
        static string ceoName;
        readonly static int lwp;
        const int estYear = 2001;

        public Variable(int EmpId, string Name, double Salary)
        {
            this.empId = EmpId;
            this.name = Name;
            this.salary = Salary;
        }
        static Variable()           //static constructor doesnt have access modifier and parameters
        {
            ceoName = "Sandeep";        //initialised within the static constructor
            lwp = 2;
        }
       
        public static void Main(string[] args)
        {
            Variable obj = new Variable(101, "SACHIN", 12000);
            Console.Write(obj.empId+" "+obj.name+" "+obj.salary+" ");
            Console.Write(ceoName + " " + lwp+" "+ estYear);        //access without object directly with the variable name
            Console.WriteLine();
            Console.ReadLine();

        }
    }
    
}
