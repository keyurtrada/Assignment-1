using System;
public class exercise11
{
    static void Main()
    {
        Console.WriteLine("Enter a number :");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0}{0}{0}",x);
        Console.WriteLine("{0} {0}", x);
        Console.WriteLine("{0} {0}", x);
        Console.WriteLine("{0} {0}", x);
        Console.WriteLine("{0}{0}{0}", x);
    }

}
