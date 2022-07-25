using System;
public class exercise40
{
    static void Main()
    {
        int sum = 0;
        int[] b = {1,2,2,3,3,4,5,6,5,7,7,7,8,8,1};
        for (int i = 0; i <= 14; i++)
        {
            sum = sum + b[i];
        }
        Console.WriteLine("Sum:"+sum);
    }

}
 