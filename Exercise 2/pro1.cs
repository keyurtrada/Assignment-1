using System;
class pro1
{
    static void Main()
    {
        char a, b, c;
        Console.WriteLine("Enter Letter:");
        a = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Enter Letter:");
        b = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Enter Letter:");
        c = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("{0} {1} {2}", c, b, a);
    }
}
