using System;
using System.Data;

internal class Assignment
{
    public int factorial(int num)
    {
        int fact = 1;
        for(int i = 1; i <= num; i++)
        {
            fact = fact * i;
        }
        return fact;
    }
    public void fibonacci(int num)
    {
        int fib1 = 0;
        int fib2 = 1;
        int fib3;
        if (num == 0)
        {
            Console.WriteLine(fib1);
        }
        else if (num == 1)
        {
            Console.WriteLine(fib1+" "+fib2);
        }
        else
        {
            Console.Write(fib1 + " " + fib2 +" ");
            for (int i = 2; i < num; i++)
            {
                fib3 = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib3;
                Console.Write(fib3+" ");
            }
            Console.WriteLine();
        }
    }
    public bool Prime(int num)
    {
        bool prime = true;
        for(int i=2;i<num;i++)
        {
            if (num % i == 0)
            {
                prime = false;
                return prime;
            }
        }
        return prime;
    }

    public static void Main(string[] args)
    {
        Assignment obj = new Assignment();
        bool repeat = true;
        while (repeat) {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Please select option\n1 for factorial\n2 for fibonacci\n3 for prime");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine(obj.factorial(num));
                    break;
                case 2:
                    obj.fibonacci(num);
                    break;
                case 3:
                    Console.WriteLine(obj.Prime(num));
                    break;
                default:
                    Console.WriteLine("Not a valid option");
                    break;
            }
            Console.WriteLine("Do you want to continue:\nyes or no");
            string cont= Console.ReadLine();
            switch (cont)
            {
                case "yes":
                    break;
                case "no":
                    repeat=false;
                    break;
            }

        }
    }
}

