using System;
public class exercise42
{
    static void Main()
    {
        int[] b = {1,2,8};
        int c = 0;
        c=b[2];
        b[2] = b[0];
         b[0] = b[1];
            b[1] = c;
            
        for (int i = 0; i <= 2; i++)
        {
            Console.Write("{0} ",b[i]);
        }
    }

}
 