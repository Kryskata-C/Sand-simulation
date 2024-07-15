using System;

class Program
{
    static string[][] grid;

    static void Main()
    {
        int rows = 16;
        int cols = 16;

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

        AddGrainOfSand(0, 1);
        AddGrainOfSand(2, 1);
        AddGrainOfSand(2, 3);

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
                    Console.ForegroundColor = ConsoleColor.White;
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
        if (row >= 0 && row < grid.Length && col >= 0 && col < grid[row].Length)
        {
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

    static void ExplodeGrainsOfSand(int seccondsTimeWaitFromStart)
    {

    }


    static void RefreshGrid()
    {
        PrintGrid();
    }
}
