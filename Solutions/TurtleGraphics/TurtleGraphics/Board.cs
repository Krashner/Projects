using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics
{
    public class Board
    {

        public const char EMPTY_SYMBOL = '.';

        //set board array size
        public Board(int sizeX, int SizeY)
        {
            boardArray = new char[sizeX, SizeY];
            InitBoard();
        }

        public static char[,] boardArray { get; set; }

        //populate the array
        public void InitBoard()
        {
            for (int x = 0; x < boardArray.GetLength(0); x++)
            {
                for (int y = 0; y < boardArray.GetLength(1); y++)
                {
                    boardArray[x, y] = EMPTY_SYMBOL;
                }
            }
        }

        //redraw the board
        public void DrawBoard(int turtleX, int turtleY, char turtleSymbol)
        {
            for (int y = 0; y < boardArray.GetLength(1); y++)
            {
                for (int x = 0; x < boardArray.GetLength(0); x++)
                {
                    if (x == turtleX && y == turtleY)
                    {
                        Console.Write(turtleSymbol);
                    }
                    else
                    {
                        Console.Write(boardArray[x, y]);
                    }
                }
                Console.Write("\n");
            }
        }

    }
}
