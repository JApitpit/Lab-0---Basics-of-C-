
using System;
using System.Globalization;

class Program
{

    private double n1 = 0;
    private double n2 = 0;
    private List<double> nums = new List<double>();


    public static void Main(string[] args)
    {

        Program obj = new Program();

        // call methods
        obj.TakeInput();

        obj.GetDifference();

        obj.List();
      
        obj.WriteNums(obj.n1, obj.n2);

        obj.PrimeNums(obj.n1, obj.n2);

    }

    //methods
    private void TakeInput()
    {

        Console.WriteLine("Enter low number");
        n1 = double.Parse(Console.ReadLine());

        while (n1 < 0)
        {
            Console.WriteLine("Enter low number");
            n1 = double.Parse(Console.ReadLine());
        }

        while (true)
        {
            Console.WriteLine("Enter high number");
            n2 = double.Parse(Console.ReadLine());

            if (n2 >= n1)
                break;
        }
    }

    private void List()
    {
        for (double i = n1; i <= n2; i++)
        {
            nums.Add(i);
        }
    }

    private void GetDifference()
    {
        if (n1 > n2) 
        {
            double diff = n1 - n2;
            Console.WriteLine("The Difference is: " + diff);
        }
        else
        {
            double diff = n2 - n1;
            Console.WriteLine("The Difference is: " + diff);
        }
    }

    private void WriteNums(double start, double end)
    {
        // add replace directory to where your "numbers.txt" file is
        StreamWriter writer = new StreamWriter("C:\\Assignments\\Lab 0 - Basics of C#\\Lab 0 - Basics of C#\\numbers.txt");

        for (double i = end; i >= start; i--) 
        {
            writer.WriteLine(i);
        }

        writer.Close();
    }

    private void PrimeNums(double start, double end)
    {

        Console.WriteLine("Prime numbers in between " + start + " and " + end);

        for (double i = start; i < end; i++)
        {
            bool isPrime = IsPrime(i);

            if (isPrime == true)
            {
                Console.WriteLine(i);
            }
        }

    }

    private bool IsPrime(double target)
    {
        if (target == 1)
            return false;
        for (double i = 2; i < target; i++)
        {
            if (target % i == 0)
            {
                return false;
            }
        }

        return true;
    }

}

