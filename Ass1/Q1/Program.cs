using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
           if(i%3==0 && i%5==0){
            Console.WriteLine(i);
           }
        }
    }
}