using System;

class Program
{
    static void Main(string[] args)
    {
        //array with data
        int[] array = new int[] { 5, 62, 83, 14, -25, 6, 73, 48, 39, 10 };

        //find minimum value
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        Console.WriteLine("Minimum value is: {0}", min);

        //find maximum value
        int max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        Console.WriteLine("Maximum value is: {0}", max);

        //find odd values
        int[] odd = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                odd[i] = array[i];
            }
        }
        //print odd values
        Console.WriteLine("Odd values are: ");
        for (int i = 0; i < odd.Length; i++)
        {
            if (odd[i] != 0)
            {
                Console.WriteLine(odd[i]);
            }
        }

        //find even values
        int[] even = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                even[i] = array[i];
            }
        }
        //print even values
        Console.WriteLine("Even values are: ");
        for (int i = 0; i < even.Length; i++)
        {
            if (even[i] != 0)
            {
                Console.WriteLine(even[i]);
            }
        }

    }
}
