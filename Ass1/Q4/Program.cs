using System;
class Program
{
    public static void Main(String[] args)
    {
        //Fahrenheit to Celsius Conversion
        Console.WriteLine("Enter the temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine("Your body temperature in Celsius degrees is: " + celsius);
        if (celsius > 37)
        {
            Console.WriteLine("You are ill!");
        }
    }
}