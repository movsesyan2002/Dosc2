// Task 1: Fibonacci Sequence Generator
// Task: Write a program that generates the first N numbers of the Fibonacci sequence using a loop.


using System;

class Program {
    
    static void Main(string[] args) 
    {
        Console.Write("enter index ");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine($"the index is {index} and the val is {Fib(index)}");

    }

    static int Fib(int n) 
    {
        if (n == 0)
        {
            return 0;
        }

        else if (n == 1)
        {
            return 1;
        }

        int first = 0;
        int second = 1;
        int next = 0;
        for (int i = 2; i <= n; i++)
        {
            next = first + second;
            first = second;
            second = next;
        }

        return next;
    }


}