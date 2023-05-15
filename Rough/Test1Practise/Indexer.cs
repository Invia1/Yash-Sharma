using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test1Practise
{
    class Indexer
    {
        object[] arr=new object[10];
        public object this[int i]
        {
            get {
                return arr[i];
            }
            set
            {
                arr[i] = value;
            }
        }
    }
    class person
    {
        public static void Main(string[] args)
        {
            Indexer i = new Indexer();
            i[0] = 12;
            i[1] = 93;
            Console.WriteLine(i[0] + " " + i[1] + " ");
            Console.ReadLine();
        }
    }
}

