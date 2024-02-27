﻿class Program
{
    static void Main(string[] args)
    {
        /* Random r = new Random();
         int[] numbers = { r.Next(1, 10), r.Next(1, 10), r.Next(1, 10), r.Next(1, 10), r.Next(1, 10), r.Next(1, 10) };
         var numberSubset = numbers[1..4];
         Console.WriteLine($"Total of the numbers array={Add(numbers)}");
         Console.WriteLine($"Total of the subset array={Add(numberSubset)}");
         Console.WriteLine($"Total of 10,20,30,40,50 = {Add(10, 20, 30, 40, 50)}");
        */
        Random r = new Random();
        Console.WriteLine("How many random numbers do you want to generate?");
        int num = int.Parse(Console.ReadLine());
        int[] numbers = new int[num];
        for (int i = 0; i < num; i++)
        {
            numbers[i] = r.Next(1, 10);
        }
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        Console.WriteLine($"Total of the numbers array={Add(numbers)}");
        Console.WriteLine($"Total of the numbers array={Multiply(numbers)}");


    }
    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }
    static int Multiply(params int[] numbers)
    {
        int total = 1;
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }

}



