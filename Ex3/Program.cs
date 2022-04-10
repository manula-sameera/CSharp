using System;

class Ex3
{

    //use params to pass in any number of arguments
    static void Print(params int[] numbers)
    {
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }

    static void Main()
    {
        //create array
        int[] array = new int[] { 5, 62, 83, 14, -25, 6, 73, 48, 39, 10 };
        Print(array);
    }
}