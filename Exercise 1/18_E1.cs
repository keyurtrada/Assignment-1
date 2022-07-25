using System;
public class exercise18
{
    static void Main()
    {
        Console.WriteLine("Input first integer :");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second integer  :");
        int y = Convert.ToInt32(Console.ReadLine());
        if (x == y)
        {
            Console.WriteLine("{0} + {1} X 3 = {2}",x,y,(x+y)*32);
        }
        else
        {
            Console.WriteLine("{0} + {1} = {2}",x,y,x+y);
        }
    }

}
 