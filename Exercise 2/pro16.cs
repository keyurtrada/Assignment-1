using System;
public class pro16
{
    static void Main(string[] args)
    {
        int m;
        Console.Write("Enter Height of Person: ");
        m = Convert.ToInt32(Console.ReadLine());
        if (m>150)
        {
            Console.WriteLine("The person is Tall");
        }
        else if (m < 150)
        {
            Console.WriteLine("The person is Dwarf");
        }
        else
        {
            Console.WriteLine("The person is Average Height");
        }
    }
}