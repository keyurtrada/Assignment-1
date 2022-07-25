using System;
public class exercise37
{
    static void Main()
    {
        Console.WriteLine("Input First Number:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input Second Number:");
        int b = Convert.ToInt32(Console.ReadLine());
        if(a==b)
        {
            Console.WriteLine("0"); 
        }
        int z=Math.Abs(20-a);
            int y=Math.Abs(20-b);
            if (z<y)
            {
                Console.WriteLine(""+a);
            }
            else
            {
                Console.WriteLine(""+b);
            }
        
    }

}
 