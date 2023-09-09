using System;

public class Exercise_02
{
    public void run()
    {   
        Console.WriteLine("Exercise 02");
        Console.WriteLine("Input the product value: ");
        double product_value = double.Parse(Console.ReadLine());

        product_value += product_value * 0.1;

        Console.WriteLine("New product value: " + product_value);
    }
}