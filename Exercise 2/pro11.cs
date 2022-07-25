using System;
public class pro11
{
    static void Main(string[] args)
    {
        int n;
        Console.Write("Enter the number \: ");
        n = Convert.ToInt32(Console.ReadLine());
        if(n%2!=0)
        {
            Console.WriteLine("{0} is Odd",n);
        }
        else
        {
            Console.WriteLine("{0} is Even", n);
        }
    }
}