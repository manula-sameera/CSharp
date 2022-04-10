using System;

class metrix
{
    static void Main()
    {
        //create two metrix
        int[,] metrix1 = new int[2,2];
        int[,] metrix2 = new int[2,2];

        //enter the values in the metrix1
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write("metrix1[{0},{1}] = ", i, j);
                //metrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        //enter the values in the metrix2
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write("metrix2[{0},{1}] = ", i, j);
                //metrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        //print the metrix1
        Console.WriteLine("Metrix 1:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(metrix1[i, j] + " ");
            }
            Console.WriteLine();
        }
        //print the metrix2
        Console.WriteLine("Metrix 2:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(metrix2[i, j] + " ");
            }
            Console.WriteLine();
        }

        //add the metrix
        int[,] sum = new int[2,2];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                sum[i, j] = metrix1[i, j] + metrix2[i, j];
            }
        }
        //print the sum
        Console.WriteLine("Sum:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(sum[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}