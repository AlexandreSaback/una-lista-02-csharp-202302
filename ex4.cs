using System;

public class Exercise_04
{
    public void run()
    {   
        Console.WriteLine("Exercise 04");
        Console.WriteLine("Initial money: ");
        double initial_money = double.Parse(Console.ReadLine());

        Console.WriteLine("Months: ");
        int months = int.Parse(Console.ReadLine());

        Console.WriteLine("Interest rate: ");
        double interest_rate = double.Parse(Console.ReadLine());

        double final_value = initial_money * (Math.Pow((1 + interest_rate), months));

        Console.WriteLine("Monetary Return: " + final_value);
    }
}