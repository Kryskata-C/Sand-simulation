using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static char[][] grid;
    static Random random = new Random();

    static void Main()
    {
        int rows = 30;
        int cols = 30;

        grid = new char[rows][];
        for (int i = 0; i < rows; i++)
        {
            grid[i] = new char[cols];
            for (int j = 0; j < cols; j++)
            {
                grid[i][j] = '.'; // Use a dot for empty cells
            }
        }

        Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
        Console.SetBufferSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

        Task.Run(() => GenerateGrainsOfSand());

        while (true)
        {
            Thread.Sleep(100);
            MoveGrainOfSand();
            RefreshGrid();
        }
    }

    static void PrintGrid()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                sb.Append(grid[i][j]);
            }
            sb.AppendLine();
        }
        Console.SetCursorPosition(0, 0);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(sb.ToString());
    }
    

  

    static void AddGrainOfSand(int row, int col)
    {
        if (row >= 0 && row < grid.Length && col >= 0 && col < grid[row].Length && grid[row][col] != 'o')
        {
            grid[row][col] = 'o';
        }
    }

    static void MoveGrainOfSand()
    {
        for (int i = grid.Length - 1; i >= 0; i--)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 'o')
                {
                    if (i + 1 < grid.Length && grid[i + 1][j] == '.')
                    {
                        grid[i][j] = '.';
                        grid[i + 1][j] = 'o';
                    }
                }
            }
        }
    }

    static void GenerateGrainsOfSand()
    {
        while (true)
        {
            int row = random.Next(0, grid.Length);
            int col = random.Next(0, grid[0].Length);
            AddGrainOfSand(row, col);
            Thread.Sleep(50); 
        }
    }

    static void RefreshGrid()
    {
        PrintGrid();
    }
}
