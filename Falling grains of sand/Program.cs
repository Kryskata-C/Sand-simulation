using System;
using System.Threading.Tasks;

class Program
{
    static string[][] grid;

    static void Main()
    {
        int rows = 26;
        int cols = 26;

        grid = new string[rows][];

        for (int i = 0; i < rows; i++)
        {
            grid[i] = new string[cols];
            for (int j = 0; j < cols; j++)
            {
                grid[i][j] = "█"; 
            }
        }

        PrintGrid();

        AddGrainOfSand(24, 19);
        AddGrainOfSand(12, 6);
        AddGrainOfSand(3, 21);
        AddGrainOfSand(14, 15);
        AddGrainOfSand(8, 22);
        AddGrainOfSand(26, 10);
        AddGrainOfSand(17, 4);
        AddGrainOfSand(5, 16);
        AddGrainOfSand(11, 23);
        AddGrainOfSand(7, 18);
        AddGrainOfSand(25, 9);
        AddGrainOfSand(2, 13);
        AddGrainOfSand(19, 1);
        AddGrainOfSand(13, 24);
        AddGrainOfSand(6, 7);
        AddGrainOfSand(20, 11);
        AddGrainOfSand(15, 8);
        AddGrainOfSand(10, 3);
        AddGrainOfSand(21, 26);
        AddGrainOfSand(1, 5);
        AddGrainOfSand(16, 14);
        AddGrainOfSand(9, 25);
        AddGrainOfSand(23, 12);
        AddGrainOfSand(4, 20);
        AddGrainOfSand(18, 17);
        AddGrainOfSand(22, 2);
        AddGrainOfSand(24, 6);
        AddGrainOfSand(12, 26);
        AddGrainOfSand(3, 19);
        AddGrainOfSand(14, 13);
        AddGrainOfSand(8, 25);
        AddGrainOfSand(26, 5);
        AddGrainOfSand(17, 20);
        AddGrainOfSand(5, 11);
        AddGrainOfSand(11, 7);
        AddGrainOfSand(7, 4);
        AddGrainOfSand(25, 10);
        AddGrainOfSand(2, 18);
        AddGrainOfSand(19, 9);
        AddGrainOfSand(13, 23);
        AddGrainOfSand(6, 12);
        AddGrainOfSand(20, 15);
        AddGrainOfSand(15, 1);
        AddGrainOfSand(10, 16);
        AddGrainOfSand(21, 8);
        AddGrainOfSand(1, 3);
        AddGrainOfSand(16, 14);
        AddGrainOfSand(9, 22);
        AddGrainOfSand(23, 18);
        AddGrainOfSand(4, 24);
        AddGrainOfSand(18, 2);
        AddGrainOfSand(22, 17);
        AddGrainOfSand(24, 3);
        AddGrainOfSand(12, 21);
        AddGrainOfSand(3, 10);
        AddGrainOfSand(14, 19);
        AddGrainOfSand(8, 15);
        AddGrainOfSand(26, 1);
        AddGrainOfSand(17, 5);
        AddGrainOfSand(5, 16);
        AddGrainOfSand(11, 25);
        AddGrainOfSand(7, 6);
        AddGrainOfSand(25, 13);
        AddGrainOfSand(2, 9);
        AddGrainOfSand(19, 24);
        AddGrainOfSand(13, 20);
        AddGrainOfSand(6, 23);
        AddGrainOfSand(20, 12);
        AddGrainOfSand(15, 18);
        AddGrainOfSand(10, 4);
        AddGrainOfSand(21, 17);
        AddGrainOfSand(1, 11);
        AddGrainOfSand(16, 22);
        AddGrainOfSand(9, 14);
        AddGrainOfSand(23, 8);
        AddGrainOfSand(4, 26);
        AddGrainOfSand(18, 7);
        AddGrainOfSand(22, 3);
        AddGrainOfSand(24, 16);
        AddGrainOfSand(12, 19);
        AddGrainOfSand(3, 25);
        AddGrainOfSand(14, 9);
        AddGrainOfSand(8, 11);
        AddGrainOfSand(26, 23);
        AddGrainOfSand(17, 6);
        AddGrainOfSand(5, 20);
        AddGrainOfSand(11, 2);
        AddGrainOfSand(7, 18);
        AddGrainOfSand(25, 21);
        AddGrainOfSand(2, 13);
        AddGrainOfSand(19, 22);
        AddGrainOfSand(13, 4);
        AddGrainOfSand(6, 14);
        AddGrainOfSand(20, 1);
        AddGrainOfSand(15, 26);
        AddGrainOfSand(10, 5);
        AddGrainOfSand(21, 19);
        AddGrainOfSand(1, 15);
        AddGrainOfSand(16, 8);
        AddGrainOfSand(9, 3);
        AddGrainOfSand(23, 12);
        AddGrainOfSand(4, 17);
        AddGrainOfSand(18, 10);
        AddGrainOfSand(22, 7);
        AddGrainOfSand(12, 1);
        AddGrainOfSand(14, 7);
        AddGrainOfSand(16, 2);
        AddGrainOfSand(5, 26);
        AddGrainOfSand(9, 12);
        AddGrainOfSand(18, 21);
        AddGrainOfSand(6, 8);
        AddGrainOfSand(20, 4);
        AddGrainOfSand(22, 10);
        AddGrainOfSand(3, 17);
        AddGrainOfSand(7, 19);
        AddGrainOfSand(11, 15);
        AddGrainOfSand(13, 25);
        AddGrainOfSand(2, 11);
        AddGrainOfSand(19, 3);
        AddGrainOfSand(8, 24);
        AddGrainOfSand(1, 22);
        AddGrainOfSand(17, 6);
        AddGrainOfSand(26, 5);
        AddGrainOfSand(10, 18);
        AddGrainOfSand(4, 16);
        AddGrainOfSand(21, 9);
        AddGrainOfSand(15, 20);
        AddGrainOfSand(23, 14);
        AddGrainOfSand(24, 13);
        AddGrainOfSand(25, 7);
        AddGrainOfSand(12, 5);
        AddGrainOfSand(14, 8);
        AddGrainOfSand(16, 3);
        AddGrainOfSand(5, 23);
        AddGrainOfSand(9, 14);
        AddGrainOfSand(18, 10);
        AddGrainOfSand(6, 20);
        AddGrainOfSand(20, 12);
        AddGrainOfSand(22, 1);
        AddGrainOfSand(3, 26);
        AddGrainOfSand(7, 4);
        AddGrainOfSand(11, 19);
        AddGrainOfSand(13, 6);
        AddGrainOfSand(2, 25);
        AddGrainOfSand(19, 8);
        AddGrainOfSand(8, 3);
        AddGrainOfSand(1, 13);
        AddGrainOfSand(17, 10);
        AddGrainOfSand(26, 21);
        AddGrainOfSand(10, 2);
        AddGrainOfSand(4, 7);
        AddGrainOfSand(21, 16);
        AddGrainOfSand(15, 18);
        AddGrainOfSand(23, 9);
        AddGrainOfSand(24, 19);
        AddGrainOfSand(25, 11);
        AddGrainOfSand(12, 14);
        AddGrainOfSand(14, 6);
        AddGrainOfSand(16, 25);
        AddGrainOfSand(5, 12);
        AddGrainOfSand(9, 26);
        AddGrainOfSand(18, 9);
        AddGrainOfSand(6, 19);
        AddGrainOfSand(20, 3);
        AddGrainOfSand(22, 18);
        AddGrainOfSand(3, 14);
        AddGrainOfSand(7, 11);
        AddGrainOfSand(11, 24);
        AddGrainOfSand(13, 8);
        AddGrainOfSand(2, 10);
        AddGrainOfSand(19, 25);
        AddGrainOfSand(8, 6);
        AddGrainOfSand(1, 9);
        AddGrainOfSand(17, 2);
        AddGrainOfSand(26, 22);
        AddGrainOfSand(10, 5);
        AddGrainOfSand(4, 21);
        AddGrainOfSand(21, 13);
        AddGrainOfSand(15, 12);
        AddGrainOfSand(23, 7);
        AddGrainOfSand(24, 2);
        AddGrainOfSand(25, 10);
        AddGrainOfSand(12, 18);
        AddGrainOfSand(14, 17);
        AddGrainOfSand(16, 11);
        AddGrainOfSand(5, 13);
        AddGrainOfSand(9, 8);
        AddGrainOfSand(18, 22);
        AddGrainOfSand(6, 10);
        AddGrainOfSand(20, 25);
        AddGrainOfSand(22, 4);
        AddGrainOfSand(3, 19);
        AddGrainOfSand(7, 16);
        AddGrainOfSand(11, 8);
        AddGrainOfSand(13, 22);
        AddGrainOfSand(2, 4);
        AddGrainOfSand(19, 12);
        AddGrainOfSand(8, 20);
        AddGrainOfSand(1, 7);
        AddGrainOfSand(17, 18);
        AddGrainOfSand(26, 11);
        AddGrainOfSand(10, 1);
        AddGrainOfSand(4, 15);
        AddGrainOfSand(21, 24);
        AddGrainOfSand(15, 23);
        AddGrainOfSand(23, 2);
        AddGrainOfSand(24, 5);
        AddGrainOfSand(25, 17);
        AddGrainOfSand(12, 10);
        AddGrainOfSand(14, 3);
        AddGrainOfSand(16, 8);
        AddGrainOfSand(5, 21);
        AddGrainOfSand(9, 18);
        AddGrainOfSand(18, 25);
        AddGrainOfSand(6, 12);
        AddGrainOfSand(20, 17);
        AddGrainOfSand(22, 11);
        AddGrainOfSand(3, 1);
        AddGrainOfSand(7, 12);
        AddGrainOfSand(11, 13);
        AddGrainOfSand(13, 19);
        AddGrainOfSand(2, 21);
        AddGrainOfSand(19, 23);
        AddGrainOfSand(8, 1);
        AddGrainOfSand(1, 11);
        AddGrainOfSand(17, 14);
        AddGrainOfSand(26, 20);
        AddGrainOfSand(10, 9);
        AddGrainOfSand(4, 6);
        AddGrainOfSand(21, 2);
        AddGrainOfSand(15, 16);
        AddGrainOfSand(23, 24);
        AddGrainOfSand(24, 8);
        AddGrainOfSand(25, 3);
        AddGrainOfSand(12, 13);
        AddGrainOfSand(14, 25);
        AddGrainOfSand(16, 22);
        AddGrainOfSand(5, 9);
        AddGrainOfSand(9, 21);
        AddGrainOfSand(18, 14);
        AddGrainOfSand(6, 15);
        AddGrainOfSand(20, 16);
        AddGrainOfSand(22, 24);
        AddGrainOfSand(3, 2);
        AddGrainOfSand(7, 23);
        AddGrainOfSand(11, 9);
        AddGrainOfSand(13, 3);
        AddGrainOfSand(2, 5);
        AddGrainOfSand(19, 26);
        AddGrainOfSand(8, 7);
        AddGrainOfSand(1, 4);
        AddGrainOfSand(17, 12);
        AddGrainOfSand(26, 19);
        AddGrainOfSand(10, 15);
        AddGrainOfSand(4, 11);
        AddGrainOfSand(21, 5);
        AddGrainOfSand(15, 14);
        AddGrainOfSand(23, 3);
        AddGrainOfSand(24, 1);
        AddGrainOfSand(25, 13);
        AddGrainOfSand(12, 19);
        AddGrainOfSand(14, 8);
        AddGrainOfSand(16, 20);
        AddGrainOfSand(5, 4);
        AddGrainOfSand(9, 2);
        AddGrainOfSand(18, 17);
        AddGrainOfSand(6, 9);
        AddGrainOfSand(20, 23);
        AddGrainOfSand(22, 5);
        AddGrainOfSand(3, 6);
        AddGrainOfSand(7, 22);
        AddGrainOfSand(11, 18);
        AddGrainOfSand(13, 24);
        AddGrainOfSand(2, 14);
        AddGrainOfSand(19, 7);
        AddGrainOfSand(8, 9);
        AddGrainOfSand(1, 2);
        AddGrainOfSand(17, 21);
        AddGrainOfSand(26, 12);
        AddGrainOfSand(10, 4);
        AddGrainOfSand(4, 3);
        AddGrainOfSand(21, 10);
        AddGrainOfSand(15, 25);
        AddGrainOfSand(23, 11);
        AddGrainOfSand(24, 17);
        AddGrainOfSand(25, 6);






        while (true)
        {
            System.Threading.Thread.Sleep(100);
            MoveGrainOfSand();
            RefreshGrid();
            
        }
    }
    
    static void PrintGrid()
    {
        Console.Clear();
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == "░")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(grid[i][j]);
                }
                else
                {
                    Console.Write(grid[i][j]);
                }
            }
            Console.WriteLine();
        }
    }
    
    static void AddGrainOfSand(int row, int col)
    {
        if (row >= 0 && row < grid.Length && col >= 0 && col < grid[row].Length )
        {
            if (grid[row][col] == "░")
            {
                Console.Error.WriteLine("Grain of sand already exists at this position");
            }
            grid[row][col] = "░"; 
        }
    }

    static void MoveGrainOfSand()
    {
        for (int i = grid.Length - 1; i >= 0; i--)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == "░")
                {
                    if (i + 1 < grid.Length && grid[i + 1][j] == "█")
                    {
                        grid[i][j] = "█";
                        grid[i + 1][j] = "░";
                    }
                }
            }
        }
    }
    

    //static void ExplodeGrainsOfSand(int seccondsTimeWaitFromStart)
    //{
    //    for (int i = 0; i < grid.Length; i++ )
    //    {
    //        for(int j = 0; j < grid[i].Length; j++)
    //        {
    //            if (grid[i][j] == "░")
    //            {
    //                if(i - 1 >= 0 && grid[i - 1][j] == "█")
    //                {
    //                    grid[i - 1][j] = "░";
    //                }
    //                if(i + 1 < grid.Length && grid[i + 1][j] == "█")
    //                {
    //                    grid[i + 1][j] = "░";
    //                }
    //                if(j - 1 >= 0 && grid[i][j - 1] == "█")
    //                {
    //                    grid[i][j - 1] = "░";
    //                }
    //                if(j + 1 < grid[i].Length && grid[i][j + 1] == "█")
    //                {
    //                    grid[i][j + 1] = "░";
    //                }
    //            }
    //        }
    //    }
    //}

   


    static void RefreshGrid()
    {
        PrintGrid();
    }
}
