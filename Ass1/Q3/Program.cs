using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the array1: ");
        int size1 = Convert.ToInt32(Console.ReadLine());
        int[] arr1 = new int[size1];  
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.WriteLine("Enter the value of the array1: ");
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Enter the size of the array2: ");
        int size2 = Convert.ToInt32(Console.ReadLine());
        int[] arr2 = new int[size2];
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.WriteLine("Enter the value of the array2: ");
            arr2[i] = Convert.ToInt32(Console.ReadLine());
        }

       //check array1 and array2 are equal or not
        if (arr1.Length == arr2.Length)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    Console.WriteLine("The arrays are equal");
                }
                else
                {
                    Console.WriteLine("The arrays are not equal");
                }
            }
        }
        else
        {
            Console.WriteLine("The arrays are not equal");
        }

        
    }
}