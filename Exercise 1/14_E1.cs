using System;
public class exercise11
{
    static void Main()
    {
        Console.WriteLine("Enter the amount of celsius :");
        int x = Convert.ToInt32(Console.ReadLine());
        int kelvin = x + 273;
        int Fahrenheit = x * 18 / 10 + 32;
        Console.WriteLine("kelvin={0} \nFahrenheit={1}", kelvin, Fahrenheit);
    }

}
