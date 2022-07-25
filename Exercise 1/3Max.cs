using System;
class pro2 {
    static void Main()
    {
        Console.WriteLine("in a,b,c");
        int a = 33; int b = 34; int c = 35;
        if(a>b&&a>c)
        {
            Console.WriteLine("a is max");
        }
        else
        {
            if(b>a&&b>c)
                {
                 Console.WriteLine("b is max");
                }
            else
            {
                Console.WriteLine("c is max");
            }

        }
    }
}