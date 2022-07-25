using System;
public class exercise17
{
    static void Main()
    {
        Console.WriteLine("Input first integer :");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second integer  :");
        int y = Convert.ToInt32(Console.ReadLine());
        if(x<0 && y>0)
        {
            Console.WriteLine("Check if one is negative and one is positive: True");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Check if one is negative and one is positive: True");
        }
        else
        {
            Console.WriteLine("Check if one is negative and one is positive: False");
        }
    }

}
 