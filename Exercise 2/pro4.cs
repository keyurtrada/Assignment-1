using System;
class pro4
{
    static void Main()
    {
        double a, b, c, p;
        Console.WriteLine("Enter Radious Of circle:");
        b=Convert.ToDouble(Console.ReadLine());
        c = 3.14;
        p = 2 * c * b;
        a = c * b * b;
        Console.WriteLine("Parimeter={0}\narea={1}",p,a);

    }

}
