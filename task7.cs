// Task 7: Number Pyramid
// Task: Print a number pyramid using nested loops, like:
// 1  
// 22  
// 333  
// 4444  
// 55555  



using System;

class Program {
    
    //task7
    static void Main(string[] args) 
    {

        for (int i = 0; i < 5; ++i) 
        {
            for (int j = 0; j < i + 1; j++)
            {
                Console.Write($"{i+1}");
            }
            Console.WriteLine();
        }
        
    }


}