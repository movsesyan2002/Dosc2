// Task 6: Collatz Conjecture
// Task: Given a number N, apply the following rule until N becomes 1:
// If N is even → N = N / 2
// If N is odd → N = 3 * N + 1
// Count how many steps it takes to reach 1.

using System;

class Program {
    
    //task6
    static void Main(string[] args) 
    {
       Console.WriteLine("enter number");
       int number = int.Parse(Console.ReadLine());
       int count = 0;
       while (number != 1) 
       {
            if (number % 2 == 0)
            {
                number /= 2;
            }

            else 
            {
                number = number * 3 + 1; 
            }
            count++;
       }
       Console.WriteLine($"Count is {count}");
    }

}
