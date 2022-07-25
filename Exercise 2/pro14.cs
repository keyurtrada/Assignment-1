using System;
public class pro14
{
    static void Main(string[] args)
    {
        int n;
        Console.Write("Enter Age: ");
        n = Convert.ToInt32(Console.ReadLine());
        if (n>18)
        {
            Console.WriteLine("Congratulations! You Are Eligible For Casting Your Vote.");
        }
        else
        {
            Console.WriteLine("Sorry! You Are Not Eligible For Casting Your Vote.");
        }
    }
}