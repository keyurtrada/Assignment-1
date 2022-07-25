using System;
public class pro13
{
    static void Main(string[] args)
    {
        int n;
        Console.Write("Enter Year: ");
        n = Convert.ToInt32(Console.ReadLine());
        if (((n % 4 == 0) && (n % 100 != 0)) || (n % 400 == 0))
        {
            Console.WriteLine("{0} is Leap Year",n);
        }
        else
        {
            Console.WriteLine("{0} is not Leap Year", n);
        }
    }
}