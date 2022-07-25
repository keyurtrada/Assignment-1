using System;
public class pro20
{
    static void Main(string[] args)
    {
        int temp;
        Console.Write("Enter the Tempetaure In Centigrade: ");
        temp= Convert.ToInt32(Console.ReadLine());
        if (temp<0)
        {
            Console.WriteLine("Freezing Weather");
        }
        else if (temp >= 0 && temp < 10)
        {
            Console.WriteLine("very cold Weather");
        }
        else if (temp >= 10 && temp < 20)
        {
            Console.WriteLine("Cold Weather");
        }
        else if (temp >= 20 && temp < 30)
        {
            Console.WriteLine("Normal in Temp");
        }
        else if (temp >= 30 && temp < 40)
        {
            Console.WriteLine("Its Hot");
        }
        else if (temp >= 40)
        {
            Console.WriteLine("Its Very Hot");
        }
  
    }
}