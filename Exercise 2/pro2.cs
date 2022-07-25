using System;
class pro2
{
    static void Main()
    {
        int a, c;
        Console.WriteLine("Enter a number:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Desired Width:");
        c = Convert.ToInt32(Console.ReadLine());
        for (int i=c;i>0;i--)
        {
            for (int j = i; j > 0; j--)
            {
                Console.Write(a);
            }
            Console.WriteLine("");
        }
    }
}
