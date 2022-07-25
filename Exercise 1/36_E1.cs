using System;
public class exercise36
{
    static void Main()
    {
        Console.WriteLine("Input First Number:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input Second Number:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input Third Number:");
        int c = Convert.ToInt32(Console.ReadLine());
        if(a>b && a>c)
        {
            Console.WriteLine("Largest of Three:"+a);
            if (b > c)
            {
                Console.WriteLine("Lowest of Three:" + c);
            }
            else
            {
                Console.WriteLine("Lowest of Three:" + b);
            }
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("Largest of Three:" + b);
            if (a > c)
            {
                Console.WriteLine("Lowest of Three:" + c);
            }
            else
            {
                Console.WriteLine("Lowest of Three:" + a);
            }
        }
        else
        {
            Console.WriteLine("Largest of Three:" + c);
            if (a > b)
            {
                Console.WriteLine("Lowest of Three:" + b);
            }
            else
            {
                Console.WriteLine("Lowest of Three:" + a);
            }
        }
    }

}
 