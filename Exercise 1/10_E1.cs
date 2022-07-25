using System;
public class exercise9
{
    static void Main()
    {
        Console.WriteLine("Enter The First number:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter The Second number:");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter The Third number:");
        int z = Convert.ToInt32(Console.ReadLine());
        int a=(x+y)*z;
        int b=(x*y)+(y*z);
        Console.WriteLine("Result of specified numbers"+x+","+y+"and"+z+",(x+y).z is "+a+" and x.y+y.z is "+b);
    }

}
