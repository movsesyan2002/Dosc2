// Task 2: Reverse a Number
// Task: Given an integer, reverse its digits using a loop (e.g., 12345 → 54321)

using System;

class Program {
    

    //task2
    static void Main(string[] args) 
    {
        Console.WriteLine("enter number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"the reversed number is {reverse(number)}");

    }

    static int reverse(int num) 
    {
        int res = 0;

        while (num > 0) {
            res *= 10;
            res += num % 10;
            num /= 10;
        }
        return res;
    }

  
}