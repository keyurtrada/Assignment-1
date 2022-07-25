using System;
public class exercise21
{
    static void Main()
    {
        Console.WriteLine("Input first integer :");
        int x = Convert.ToInt32(Console.ReadLine());
        if (100-x<=20 || 200-x<=20)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }

}
 