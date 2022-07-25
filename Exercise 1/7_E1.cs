using System;
class pro7
{
    static void Main()
    {
        int a, b, c,d,e,f,g;
        Console.WriteLine("Input First Number to Multiply:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input Second Number to multiply:");
        b = Convert.ToInt32(Console.ReadLine());
        c = a + b;
        d = a - b;
        e = a * b;
        f = a / b;
        g = a % b;
        Console.WriteLine(a+"+"+b+"="+c);
        Console.WriteLine(a + "-" + b + "=" + d);
        Console.WriteLine(a + "*" + b + "=" + e);
        Console.WriteLine(a + "/" + b + "=" + f);
        Console.WriteLine(a + "mod" + b + "=" + g);
    }
}