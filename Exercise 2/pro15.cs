using System;
public class pro15
{
    static void Main(string[] args)
    {
        int m;
        Console.Write("Enter Value of m: ");
        m = Convert.ToInt32(Console.ReadLine());
        if (m>0)
        {
            Console.WriteLine("The value of n = 1");
        }
        else if (m < 0)
        {
            Console.WriteLine("The value of n = -1");
        }
        else
        {
            Console.WriteLine("The value of n = 0");
        }
    }
}