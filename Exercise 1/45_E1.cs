using System;
public class exercise45
{
    static void Main()
    {
       int count = 0;
        int[] b = {2,4,7,8,6};
        for (int i = 0; i <= 4; i++)
        {
            if (b[i] % 2 != 0)
            {
                count = 1;
            }
        }
        if (count == 1)
        {
            Console.Write("Check if an array contains an odd number?-->True");
        }
    }

}
 