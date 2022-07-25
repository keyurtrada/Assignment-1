using System;
public class exercise34
{
    static void Main()
    {
        Console.WriteLine("Input First Number:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input Second Number:");
        int b = Convert.ToInt32(Console.ReadLine());
        if(a>-10 && a<10 && b>-10 && b<10)
        {
            Console.WriteLine("True");
        }
    }

}
 