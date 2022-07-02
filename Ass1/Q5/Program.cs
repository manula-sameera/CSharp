using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter score 1-9 : ");

    here:
        int score = Convert.ToInt32(Console.ReadLine());
        if (score <= 0 || score > 9)
        {
            Console.WriteLine("Invalid score. Please enter score 1-9 : ");
            goto here;
        }
        else
        {
            if (score >= 1 && score <= 3)
            {
                Console.WriteLine("Your score is " + score * 10);
            }
            else if (score >= 4 && score <= 6)
            {
                Console.WriteLine("Your score is " + score * 100);
            }
            else if (score >= 7 && score <= 9)
            {
                Console.WriteLine("Your score is " + score * 1000);
            }

        }
    }

}