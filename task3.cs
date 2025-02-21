// Task 3: Sum of Digits
// Task: Compute the sum of all digits of a given number using a loop (e.g., 456 → 4 + 5 + 6 = 15).

using System;

class Program {
    
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
            res += num % 10;
            num /= 10;
        }
        return res;
    }

  
}