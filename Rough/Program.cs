using System;
using System.Threading;
using System.Threading.Tasks;
// Part 2 Video of BANGAR RAJU
namespace ThreadingPresentation
{
    internal class Program
    {
        static void Test1()
        {
            for(int i=1; i<=10;i++)
            {
                Console.Write("Test1:");
                Console.WriteLine(i);   
            }
        }
        static void Test2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Test2:"+i);
                if (i == 5)
                {
                    Console.WriteLine("Test 2 is Going to sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Test 2 is woke up now");
                }
            }
        }
        static void Test3()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Test3:"+i);
            }
        }
        static void Main(string[] args)
        {
            Thread t1=new Thread(Test1);
            Thread t2=new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }
    }
}
