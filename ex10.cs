using System;

public class Exercise_10
{
    public void run()
    {   
        Console.WriteLine("Exercise 10");
        Console.WriteLine("First Value: ");
        double first_value = double.Parse(Console.ReadLine());

        Console.WriteLine("Second Value: ");
        double second_value = double.Parse(Console.ReadLine());

        Console.WriteLine("Third Value: ");
        double third_value = double.Parse(Console.ReadLine());

        double mean = (first_value + second_value + third_value) / 3;
        double harmonic_mean = 3 / ((1/first_value) + (1/second_value) + (1/third_value));
        double geometric_mean = Math.Pow((first_value * second_value * third_value), 1.0/3.0);
        
        Console.WriteLine($"mean: {mean}\n harmonic_mean: {harmonic_mean}\n geometric_mean: {geometric_mean}");
    }
}