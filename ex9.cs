using System;

public class Exercise_09
{
    public void run()
    {   
        Console.WriteLine("Exercise 09");
        Console.WriteLine("Input Seconds: ");
        int seconds = int.Parse(Console.ReadLine());

        int minutes = (seconds/60) % 60;
        int hours = seconds/60/60;

        seconds = seconds % 60;
        
        Console.WriteLine($"Converted time: {hours}:{minutes}:{seconds}");
    }
}