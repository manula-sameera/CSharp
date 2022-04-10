using System;

class car
{
    //declare the variables
    private string brand = "";
    private string price = "";

    //default constructor
    public car()
    {
        Console.WriteLine("This information is about a car");
    }

    //parameterized constructor
    public car(string brand, string price)
    {
        this.brand = brand;
        this.price = price;
    }

    //method to display the information
    public void display()
    {
        Console.WriteLine("The brand is {0} and the price is {1}", brand, price);
    }
    static void Main()
    {
        //creating object with default constructor
        car c = new car();
        //creating object with parameterized constructor
        car c1 = new car("Bugatti", "2200000");
        //calling the display method
        c1.display();
    }
}