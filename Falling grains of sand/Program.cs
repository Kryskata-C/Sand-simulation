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
                grid[i][j] = '.'; 
            }
        }

        Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
        Console.SetBufferSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

        Task.Run(() => GenerateGrainsOfSand());
        Task.Run(() => MonitorKeyPress());

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
    static void explodeGrains()
    {
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 'o')
                {
                    int row = random.Next(5, 10);
                    int col = random.Next(5, 10);
                    if(random.Next(0, 2) == 0)
                    {
                        if(i - row >= 0)
                        {
                            grid[i][j] = '.';
                            grid[i - row][j] = 'o';
                        }
                    }
                    else
                    {
                        if(i + row < grid.Length)
                        {
                            grid[i][j] = '.';
                            grid[i + row][j] = 'o';
                        }
                    }
                    if(random.Next(0, 2) == 0)
                    {
                        if(j - col >= 0)
                        {
                            grid[i][j] = '.';
                            grid[i][j - col] = 'o';
                        }
                    }
                    else
                    {
                        if(j + col < grid[i].Length)
                        {
                            grid[i][j] = '.';
                            grid[i][j + col] = 'o';
                        }
                    }
                }
            }
        }
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

    static void MonitorKeyPress()
    {
        while (true)
        {
            if (Console.KeyAvailable)
            {
                Console.ReadKey(true); 
                explodeGrains();
            }
            Thread.Sleep(10); 
        }
    }
}
