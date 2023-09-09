using System;

public class Exercise_01
{
    public void run()
    {   
        Console.WriteLine("Exercise 01");
        Console.WriteLine("Input the first number: ");
        double number1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Input the second number: ");
        double number2 = double.Parse(Console.ReadLine());

        double mean = (number1 + number2) / 2;
        Console.WriteLine("The average is: " + mean);
    }
}