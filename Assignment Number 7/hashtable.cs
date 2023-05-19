using System;
using System.Collections;       //HashTable is in collection


namespace AllGenerics
{
    internal class hashtable
    {
        public static void Main(string[] args)
        {
            Hashtable str = new Hashtable();
            str.Add("Eid", 1001);               //KEY,VALUE
            str.Add("Name","Yash");
            foreach(var obj in str.Keys)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Eid" + " " + str["Eid"]);

            str.Remove("Yash");                 
            
            foreach(var obj in str.Keys)
            {
                Console.WriteLine(obj+" -> " + str[obj]);
               // Console.WriteLine(str.Value);
            }

            Console.WriteLine(str.ContainsKey("Eid")); 
            Console.WriteLine(str.ContainsValue("Yash")); 
            
            Console.ReadLine();
        }
    }
}
