using System;
class pro3{
    static void Main()
    {
        Console.WriteLine("1...100 prime numbers are....");
        int check = 0; int a = 0;
        for(int i=2;i<=100;i++)
        {
            check = 0;
            a=i/2;
            for(int j=2;j<=a;j++)
            {
                if(i%j==0)
                {
                    check=1;
                    break;
                }
            }
            if(check==0)
            {
                Console.WriteLine(" "+i);
            }
        }
    }

}