using System;
public class exercise20
{
    static void Main()
    {
        Console.WriteLine("Input first integer :");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second integer  :");
        int y = Convert.ToInt32(Console.ReadLine());
        if (x==20)
        {
            Console.WriteLine("{0} + {1} = {2}",x,y,(x+y)+"True");
        }
        else if (x + y == 20)
        {
            Console.WriteLine("{0} + {1} = {2}", x, y, (x + y) + "True");
        }
        else if (y == 20)
        {
            Console.WriteLine("{0} + {1} = {2}", x, y, (x + y) + "True");
        }
        else
        {
            Console.WriteLine("{0} + {1} = {2}", x, y, (x + y) + "False");
        }
    }

}
 