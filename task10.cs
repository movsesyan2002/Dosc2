// Task 10: Maze Solver (Grid Navigation)
// Task: Create a 10x10 grid, place an "X" in one random location, and move a player (P) using loop-based logic to find "X".

using System;

class Program {
      
    static void Main(string[] args) {
        char [,] mtx = new char[10,10];
        Random rnd = new Random();
       mtx[rnd.Next(0,9), rnd.Next(0,9)] = 'X';
       for (int i = 0; i < 10; ++i)
       {
        for (int j = 0; j < 10; ++j) 
        {
            if (mtx[i,j] == 'X') {
                Console.WriteLine($"the X was found at {i} {j}");
                return;
            }
        }
       }
        Console.WriteLine("the X was not found");
    }

}
