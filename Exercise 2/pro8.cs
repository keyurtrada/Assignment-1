using System;
class pro8
{
    static void Main()
    {
        Console.WriteLine("Input First:");
     int r = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Input Second:");
     int s = Convert.ToInt32(Console.ReadLine());

     if (r % 2 != 0 && s % 2 != 0 || r % 2 == 0 && s % 2 == 0)
     {
         Console.WriteLine("True");
     }
     else
     {
         Console.WriteLine("False");

     }

    }
}