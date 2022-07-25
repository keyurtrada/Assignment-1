using System;
public class exercise43
{
    static void Main()
    {
        int[] b = {1,2,5,7,8};
        if (b[0] > b[4])
        {
            Console.WriteLine("Highest value between first and last values of the said array:"+b[0]);
        }
        else
        {
            Console.WriteLine("Highest value between first and last values of the said array:" + b[4]);
        }
    }

}
 