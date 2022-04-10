using System;
using System.Collections;

class DSProgram
{
    static void Main()
    {
        bool[] array = new bool[05];
        array[0] = true;
        array[1] = false;
        array[2] = true;
        array[3] = false;
        array[4] = true;

        //create bit array
        BitArray bitArray = new BitArray(array);
        //print bit array
        Console.WriteLine("Bit array: ");
        foreach (bool value in bitArray)
        {
            Console.Write(value + " ");
        
        }

    }
}