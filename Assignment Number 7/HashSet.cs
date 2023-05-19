using System;
using System.Collections.Generic;


namespace AllGenerics
{
    internal class HashSet
    {
        
        static void Main(string[] args)
        {
            HashSet<int> c = new HashSet<int>();
            c.Add(9);
            c.Add(7);   //so it will not give duplicate 7 it will take 7 only one time like set print only 1 time
            c.Add(7);
            c.Add(1);

            Console.WriteLine(c.Contains(9));

            c.Remove(7);

            foreach(int s in c) { Console.WriteLine(s); }

            Console.ReadLine();
        }
    }
}
