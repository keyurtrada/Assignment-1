using System;
public class exercise31
{
    static void Main()
    {
        Console.WriteLine("Input Number:");
        int a = Convert.ToInt32(Console.ReadLine());
        if(a%3==0 || a%7==0)
        {
            Console.WriteLine("True");
        }
    }

}
 