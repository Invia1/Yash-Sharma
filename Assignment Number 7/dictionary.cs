using System;
using System.Collections.Generic;
using System.Linq;

namespace AllGenerics
{
    internal class dictionary
    {
        public static void Main(string[] args)
        {
            Dictionary<string,int> dic = new Dictionary<string,int>();
            dic.Add("yash", 101);
            dic.Add("sachin", 102);
            dic.Add("rohan", 103);
            dic.Add("mayank", 104);

            dic.Remove("yash");

            Console.WriteLine(dic.ContainsKey("sachin"));
            Console.WriteLine(dic.ContainsValue(101));

            //foreach(var obj in dic.Keys)
            //{
            //    Console.Write(obj);
            //    Console.WriteLine(dic[obj]);
            //}

            foreach (var obj in dic)
            {
                Console.WriteLine(obj);
            }

            Console.ReadLine();
        }
    }
}
