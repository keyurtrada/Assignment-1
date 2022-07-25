using System;
public class pro10
{
    static void Main(string[] args)
    {
        int n, i;
        Console.Write("Enter the number: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number: ");
        i = Convert.ToInt32(Console.ReadLine());
        if(n==i)
        {
            Console.WriteLine("{0} and {1} are Equal",n,i);
        }
        else
        {
            Console.WriteLine("{0} and {1} are not Equal", n, i);
        }
    }
}