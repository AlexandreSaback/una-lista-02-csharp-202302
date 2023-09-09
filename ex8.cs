using System;

public class Exercise_08
{
    public void run()
    {   
        Console.WriteLine("Exercise 08");
        Console.WriteLine("Number of vehicles: ");
        int vehicles_number = int.Parse(Console.ReadLine());

        Console.WriteLine("Number of wheels: ");
        int wheels_number = int.Parse(Console.ReadLine());
        
        int motorcycles_number = vehicles_number % 4;
        int cars_number = vehicles_number - motorcycles_number;
        
        Console.WriteLine($"There are {cars_number} cars and {motorcycles_number} motorcycles on the parking");
    }
}