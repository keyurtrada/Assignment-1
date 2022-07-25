using System;
class pro6
{
    static void Main()
    {
        double s = 0,v = 0;
        Console.WriteLine("Radious:");
        double r = Convert.ToDouble(Console.ReadLine());
         s = 4 * (3.14) * r * r;
         v = (4* (3.14) *( r * r * r))/3;
        Console.WriteLine("{0}\n{1}", s, v);
    }
}