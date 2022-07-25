using System;
public class exercise39
{
    static void Main()
    {
        Console.WriteLine("Input an integer :");
        int a = Convert.ToInt32(Console.ReadLine());
        int[] b = { 5, 7, 6, 2, 35, 1, 6, 8, 9, 4, 5, 6 };
        if (a == b[0])
        {
            Console.WriteLine("True");
        }
        else if (a == b[11])
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        
    }

}
 