using System;
class pro3
{
    static void Main()
    {
        int x,b,y;
        Console.WriteLine("Input First number:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input Operation:");
        b = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Input Second numaber:");
        y = Convert.ToInt32(Console.ReadLine());
        if (b == '+')
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        else if (b == '-')
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
        else if ((b == 'x') || (b == '*'))
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
        else if (b == '/')
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
        else
            Console.WriteLine("Wrong Character");
    }
}
