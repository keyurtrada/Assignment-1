using System;
class pro5
{
    static void Main()
    {
        int a, b, c=0;
        Console.WriteLine("Input First Number:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input Second Number:");
        b = Convert.ToInt32(Console.ReadLine());
        c = a;
        a = b;
        b=c;
        Console.WriteLine("First Number:"+a);
        Console.WriteLine("Second Number:"+b);
    }
}