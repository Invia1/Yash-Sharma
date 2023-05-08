using System;
class Office
{
    
    static readonly int lwp;
    
    static Office()
    {

        lwp = 1;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(lwp );

        Console.ReadLine();

    }
}