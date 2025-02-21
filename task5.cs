// Task 5: Prime Number Checker
// Task: Check whether a given number is prime using a loop.

using System;

class Program {
    
    static void Main(string[] args) 
    {
        Console.WriteLine("enter number");
        int number = int.Parse(Console.ReadLine());
        string check = isprime(number) ? "is prime" : "not prime";
        Console.WriteLine(check);
    }

    static bool isprime(int number)
    {

        if (number == 0) {
            return false;
        }

        else if (number == 1) 
        {
            return false;
        }
        else
        {
            for (int i = 2; i <= number/2; i++)
            {
                if (number % i == 0) 
                {
                    return false;
                }
            }
            return true;
        }
    }

 
}