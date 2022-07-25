using System;
class pro6
{
    static void Main()
    {
        int a, b, c,d;
        Console.WriteLine("Input First Number to Multiply:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input Second Number to multiply:");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input Third Number to multiply:");
        c = Convert.ToInt32(Console.ReadLine());
        d = a * b * c;
        Console.WriteLine(a+"*"+b+"*"+c+"="+d);
    }
}