using System;

public class Exercise_05
{
    public void run()
    {   
        Console.WriteLine("Exercise 05");
        Console.WriteLine("Worked hours in the month: ");
        double worked_hours = double.Parse(Console.ReadLine());

        Console.WriteLine("Revenue by worked hour: ");
        int hour_revenue = int.Parse(Console.ReadLine());

        Console.WriteLine("Family revenue: ");
        double family_revenue = double.Parse(Console.ReadLine());

        Console.WriteLine("Number of children under 14 years old");
        int number_of_children = int.Parse(Console.ReadLine());

        double raw_revenue =  (worked_hours * hour_revenue) + (family_revenue * number_of_children);

        Console.WriteLine("Raw revenue: " + raw_revenue);
    }
}