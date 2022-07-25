using System;
public class exercise38
{
    static void Main()
    {
        Console.WriteLine("Input an integer :");
        int a = Convert.ToInt32(Console.ReadLine());
        int[] b = { 5, 7, 6, 2, 35, 1, 6, 8, 9, 4, 5, 6 };
        for (int i = 0; i <= 11; i++)
        {
            if (a == b[i])
            {
                Console.WriteLine("Number of {0} present in the said array:{1}",a,i);
            }
        }
        
    }

}
 