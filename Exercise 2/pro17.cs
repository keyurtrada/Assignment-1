using System;
public class pro17
{
    static void Main(string[] args)
    {
        int m,n,o;
        Console.Write("Enter 1st Number: ");
        m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2nd Number: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 3rd Number: ");
        o = Convert.ToInt32(Console.ReadLine());
        if (m>n && m>o)
        {
            Console.WriteLine("The 1st Number is the greatest among three");
        }
        else if (n>m && n>o)
        {
            Console.WriteLine("The 2nd Number is the greatest among three");
        }
        else
        {
            Console.WriteLine("The 3rd Number is the greatest among three");
        }
    }
}