using System;
public class pro9
{
    static void Main(string[] args)
    {
        int m,p,c;
        Console.Write("Enter Marks in Maths: ");
        m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Marks in Physics: ");
        p = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Marks in Chemistry: ");
        c = Convert.ToInt32(Console.ReadLine());
        if (m >= 65)
        {
            if (p >= 55)
            {
                if (c >= 50)
                {
                    if ((m + p + c) >= 180 || (m + p) >= 140)
                    {
                        Console.Write("The  candidate is eligible for admission.\n");
                    }
                    else
                    {
                        Console.Write("The candidate is not eligible.\n\n");
                    }
                }
                else
                {
                    Console.Write("The candidate is not eligible.\n\n");
                }
            }
            else
            {
                Console.Write("The candidate is not eligible.\n\n");
            }
        }
        else
        {
            Console.Write("The candidate is not eligible.\n\n");
        }
    }
}