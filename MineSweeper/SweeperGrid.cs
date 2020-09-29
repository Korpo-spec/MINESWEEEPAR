using System;

namespace MineSweeper
{
    public class SweeperGrid
    {
        public int[,] grid = new int[15, 15];
        static Random generator = new Random();

        public SweeperGrid()
        {
            for (int y = 0; y < grid.GetLength(0); y++)
            {
                for (int x = 0; x < grid.GetLength(1); x++)
                {
                    grid[x, y] = 9;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                grid[generator.Next(0, 15), generator.Next(0, 15)] = 10;
            }
        }

        public bool CheckPosition(int x, int y){

            if (grid[x,y] == 10)
            {
                return true;
            }
            return false;
        }
    }
}
