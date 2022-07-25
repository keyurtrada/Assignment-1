using System;
public class exercise44
{
    static void Main()
    {
        int[] b = {1,2,5};
        int[] c = { 0, 3, 8 };
        int[] d ={-1,0,2};
        int[] e = {b[1],c[1],d[1]};
        Console.Write("int[]e= [");
        for (int i = 0; i <= 2; i++)
        {
            Console.Write("{0} ",e[i]);
        }
            Console.Write("]");
    }

}
 