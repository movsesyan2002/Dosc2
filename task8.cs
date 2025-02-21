// Task 8: Password Generator
// Task: Create a loop-based random password generator with at least one uppercase letter, one lowercase letter, and one digit.


using System;

class Program {
       
    static void Main(string[] args) {
        const string uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string lowers  = "abcdefghijklmnopqrstuvwxyz";
        const string numbers = "0123456789";
        Random random = new Random();
        char[] result = new char[8];
        while (true) 
        {   
            string? generate = "generate";
            Console.Write("Do you want generate or exit\nfor generating enter generate\nfor exiting enter exit\n");
            string? working = Console.ReadLine();
            if (string.Compare(generate,working) == 0) {
                
                for (int i = 0; i < result.Length; i++)
                {
                    if (i < 2) {
                        result[i] = numbers[random.Next(numbers.Length)];
                    }

                    else if (i >= 2 && i < 5) {
                        result[i] = uppers[random.Next(uppers.Length)];
                    }

                    else if (i >= 5 && i < 8) {
                        result[i] = lowers[random.Next(lowers.Length)];
                    }
                }

                Console.Write("the password is ");
                Console.WriteLine(result);
            }

            else if (string.Compare(working,"exit") == 0) {
                Console.WriteLine("exited...\n");
                break;
            }
            
        }

    }


}