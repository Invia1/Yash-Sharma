using System;
using System.Collections.Generic;


namespace Test1Practise
{
    internal class Properties
    {
        string _name;
        int _age;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                if (_age > 18)
                {
                    Console.WriteLine("You are eligible for vote");
                }
                else
                {
                    Console.WriteLine("You are not eligible for vote");
                }
            }
        }
    }
    class Voter
    {
        public static void Main(string[] args)
        {
            Properties p = new Properties();
            p.age = 22;
            p.name = "yash";

            Console.ReadLine();
        }
    }
}
