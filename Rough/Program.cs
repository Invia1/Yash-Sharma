using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Journey
    {
        object[] Suitcase = new object[4];     //object means any data type
        
        public object this[int i] {
            get {
                return Suitcase[i];
            }
            set
            {
                Suitcase[i] = value;
            }
        }
    }
    class SuitcaseDetails
    {
        public static void Main(string[] args)
        {
            Journey obj = new Journey();
            obj[0] = "soap";
            obj[1] = "towel";
            obj[2] = "comb";
            obj[3] = 21;
            Console.WriteLine(obj[0]+" " + obj[1]+" " + obj[2]+" "+obj[3]);

            Journey obj2 = new Journey();
            obj[0] = true;
            obj[1] = 20.22;
            obj[2] = 90;
            obj[3] = "phone";
            Console.ReadLine();
        }
    }
}

