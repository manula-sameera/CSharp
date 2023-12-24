using System;

namespace assignment1
{

    class program
    {
        //delegate declaration
        public delegate int del1(int x, int y);
        public delegate int del2(int x);

        //add
        public static int add(int x, int y)
        {
            return x + y;
        }

        //square
        public static int square(int x)
        {
            return x * x;
        }

        //main
        public static void Main(string[] args)
        {
            //delegate example
            del1 d1 = new del1(add);
            del2 d2 = new del2(square);
            Console.WriteLine(d1(2, 3));
            Console.WriteLine(d2(2));
            Console.ReadLine();
        }

    }
}