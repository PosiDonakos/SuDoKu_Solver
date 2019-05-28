using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SuDoKu
{
    class GameConfig
    {
        
        
        public static bool itRuns = false;
        private static System.Diagnostics.Stopwatch sw;

        internal static class DefineConstants
        {
            public const int UNASSIGNED = 0;
            public const int N = 9;
        }

        public static int[,] grid =
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0}
            };
        public static int[,] newGameGrid =
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0}
            };

        /* Returns a boolean which indicates whether it will be legal to assign
           num to the given row,col location. */
        private static bool FindUnassignedLocation(int[,] grid, ref int row, ref int col)
        {
            for (row = 0; row < DefineConstants.N; row++)
            {
                for (col = 0; col < DefineConstants.N; col++)
                {
                    if (grid[row, col] == DefineConstants.UNASSIGNED)
                    {
                       
                        return true;
                    }
                }
            }
            return false;
        }

        

        // Checks whether it will be legal to assign num to the given row,col
        private static bool IsSafe(int[,] grid, int row, int col, int num)
        {
            /* Check if 'num' is not already placed in current row,
               current column and current 3x3 box */
            return !UsedInRow(grid, row, num) && !UsedInCol(grid, col, num) && !UsedInBox(grid, row - row % 3, col - col % 3, num);
        }

        /* Takes a partially filled-in grid and attempts to assign values to
          all unassigned locations in such a way to meet the requirements
          for Sudoku solution (non-duplication across rows, columns, and boxes) */
        private static bool SolveSudoku(int[,] grid)
        {
            int row = 0;
            int col = 0;

            // If there is no unassigned location, we are done
            if (!FindUnassignedLocation(grid, ref row, ref col))
            {
                return true; // success!
            }

            // consider digits 1 to 9
            for (int num = 1; num <= 9; num++)
            {
                // if looks promising
                if (IsSafe(grid, row, col, num))
                {
                    // make tentative assignment
                    grid[row, col] = num;
                    Game.Fill(col, row, num);
                    
                  
                    sw.Stop();

                    //System.Threading.Thread.Sleep(1);
                    // return, if success, yay!

                    sw.Start();

                    if (SolveSudoku(grid))
                    {
                        return true;
                    }

                    // failure, unmake & try again
                    Game.Clear(col, row);
                    grid[row, col] = DefineConstants.UNASSIGNED;


                }
            }
            return false; // this triggers backtracking
        }

        /* Returns a boolean which indicates whether any assigned entry
           in the specified row matches the given number. */
        private static bool UsedInRow(int[,] grid, int row, int num)
        {
            for (int col = 0; col < DefineConstants.N; col++)
            {
                if (grid[row, col] == num)
                {
                    return true;
                }
            }
            return false;
        }

        /* Returns a boolean which indicates whether any assigned entry
           in the specified column matches the given number. */
        private static bool UsedInCol(int[,] grid, int col, int num)
        {
            for (int row = 0; row < DefineConstants.N; row++)
            {
                if (grid[row, col] == num)
                {                    
                    return true;
                }
            }
            return false;
        }

        /* Returns a boolean which indicates whether any assigned entry
           within the specified 3x3 box matches the given number. */
        private static bool UsedInBox(int[,] grid, int boxStartRow, int boxStartCol, int num)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (grid[row + boxStartRow, col + boxStartCol] == num)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /* Cleans the board */
        public static void CleanBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    grid[i, j] = newGameGrid[i, j];
                }
            }
            
            Game.FirstFill(grid);
        }

        public static void NewGame(int x)
        {
            newGameGrid = Boards(x);
            Game.FirstFill(grid = Boards(x));
        }

        public static int[,] Boards(int x)
        {

            
            if (x == 1)
            {
                int[,] table ={
                    { 3, 0, 6, 5, 0, 8, 4, 0, 0},
                    { 5, 2, 0, 0, 0, 0, 0, 0, 0},
                    { 0, 8, 7, 0, 0, 0, 0, 3, 1},
                    { 0, 0, 3, 0, 1, 0, 0, 8, 0},
                    { 9, 0, 0, 8, 6, 3, 0, 0, 5},
                    { 0, 5, 0, 0, 9, 0, 6, 0, 0},
                    { 1, 3, 0, 0, 0, 0, 2, 5, 0},
                    { 0, 0, 0, 0, 0, 0, 0, 7, 4},
                    { 0, 0, 5, 2, 0, 6, 3, 0, 0}
                };
                return table;
            }
            else if(x ==2)
            {
                int[,] table ={
                    { 0, 0, 3, 0, 5, 0, 0, 4, 0},
                    { 0, 1, 0, 0, 0, 6, 0, 0, 3},
                    { 0, 0, 0, 8, 0, 0, 1, 2, 5},
                    { 0, 0, 6, 0, 0, 4, 3, 0, 2},
                    { 0, 8, 0, 0, 3, 0, 0, 6, 0},
                    { 5, 0, 4, 6, 0, 0, 7, 0, 0},
                    { 3, 2, 7, 0, 0, 8, 0, 0, 0},
                    { 6, 0, 0, 3, 0, 0, 0, 8, 0},
                    { 0, 5, 0, 0, 2, 0, 4, 0, 0}
                };
                return table;
            }
            else
            {
                int[,] table ={
                    { 7, 0, 0, 3, 0, 0, 4, 0, 0},
                    { 0, 0, 4, 0, 7, 0, 0, 0, 0},
                    { 0, 8, 0, 0, 0, 0, 7, 0, 2},
                    { 0, 0, 0, 5, 0, 6, 0, 2, 0},
                    { 0, 2, 0, 0, 0, 0, 0, 8, 0},
                    { 0, 5, 0, 1, 0, 3, 0, 0, 0},
                    { 5, 0, 3, 0, 0, 0, 0, 6, 0},
                    { 0, 0, 0, 0, 9, 0, 2, 0, 0},
                    { 0, 0, 7, 0, 0, 5, 0, 0, 9}
                };
                return table;
            }
            
        }
        
        /* Driver Program to test above functions */
        public static void Run( object o)
        { 
            Game ParentForm = (Game)o;
            Run(ParentForm);
        }

        public static void Run(Game ParentForm)
        {
            
             itRuns = true;
             sw = System.Diagnostics.Stopwatch.StartNew();
            if (SolveSudoku(grid) == true)
            {
                sw.Stop();
               Game.FirstFill(grid);
                 ParentForm.CheckSolved(true,  sw.ElapsedMilliseconds / 1000);
            }
            else
            {
                ParentForm.CheckSolved(false , sw.ElapsedMilliseconds / 1000);
            }

            
        }

        
    }
}
