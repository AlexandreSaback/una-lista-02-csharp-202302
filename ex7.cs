using System;

public class Exercise_07
{
    public void run()
    {   
        Console.WriteLine("Exercise 07");
        Console.WriteLine("Fix Revenue Value: ");
        double fix_revenue = double.Parse(Console.ReadLine());

        Console.WriteLine("Total Sale Value: ");
        double sale_value = double.Parse(Console.ReadLine());

        Console.WriteLine("Sale Percentual: ");
        double sale_percentual = double.Parse(Console.ReadLine());

        Console.WriteLine(sale_percentual);
        double total_revenue = fix_revenue + (sale_value * sale_percentual);
        
        Console.WriteLine("Total Revenue: " + total_revenue);
    }
}