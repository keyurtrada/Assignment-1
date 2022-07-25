using System;
public class pro12
{
    static void Main(string[] args)
    {
        int n;
        Console.Write("Enter the number: ");
        n = Convert.ToInt32(Console.ReadLine());
        if(n>0)
        {
            Console.WriteLine("{0} is Positive Number",n);
        }
        else
        {
            Console.WriteLine("{0} is Negative Number", n);
        }
    }
}