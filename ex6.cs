using System;

public class Exercise_06
{
    public void run()
    {   
        Console.WriteLine("Exercise 06");
        Console.WriteLine("Input the first number: ");
        double number1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Input the second number: ");
        double number2 = double.Parse(Console.ReadLine());

        double logarithm = Math.Log(number1, number2);
        
        Console.WriteLine($"Log of {number1} on base {number2}: {logarithm}");
    }
}