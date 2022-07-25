using System;
public class exercise9
{
    static void Main()
    {
        Console.WriteLine("Enter The First number:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter The Second number:");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter The Third number:");
        double z = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter The Fourth number:");
        double w = Convert.ToDouble(Console.ReadLine());
        double a=(x + y + z + w) / 4;
        Console.WriteLine("The average of " + x + "," + y + "," + z + "," + w + " is:" + a);
    }

}
