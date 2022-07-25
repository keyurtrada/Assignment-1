using System;
public class pro19
{
    static void Main(string[] args)
    {
        int rn,phy,che,ca,tot;
        double per;
        string nm,div;
        Console.Write("Enter the Roll Number of the Student: ");
        rn = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Name of The Student: ");
        nm =Console.ReadLine();
        Console.Write("Enter Marks of Physics,Chemistry and Computer Application: ");
        phy = Convert.ToInt32(Console.ReadLine());
        che= Convert.ToInt32(Console.ReadLine());
        ca = Convert.ToInt32(Console.ReadLine());
        tot = phy + che + ca;
        per=(tot)/3;
        if (per >= 80)
        {
            div = "First";
        }
        else if (per < 80 && per > 60)
        {
            div = "Second";
        }
        else
        {
            div = "Third";
        }
        Console.WriteLine("Roll No: {0}\n Name of Student:{1}\n Marks in Physics:{2}\n Marks in Chemistry:{3}\n Marks in Computer Application:{4}\n Total Marks={5}\n Percentage={6} \n Division={7}",rn,nm,phy,che,ca,tot,per,div);    
    }
}