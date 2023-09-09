using System;

public class Exercise_03
{
    public void run()
    {   
        Console.WriteLine("Exercise 03");
        Console.WriteLine("Input Fahrenheit Temperature: ");
        double fahrenheit_temperature = double.Parse(Console.ReadLine());

        double celsius_temperature = (fahrenheit_temperature - 32) / 1.8;

        Console.WriteLine("Temperature converted to Celsius: " + celsius_temperature);
    }
}