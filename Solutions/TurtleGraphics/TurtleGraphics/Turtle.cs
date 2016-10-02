using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics
{
    class Turtle
    {
       
        public Turtle()
        {
            symbol = 'X';
            posX = 0;
            posY = 0;
        }

        public char symbol { get; set; }
        public int posX { get; set; }
        public int posY { get; set; }
        public bool draw { get; set; }

        //move the turtle
        public void UpdatePosition(string stringDir, int distance, bool canDraw)
        {
            draw = canDraw;
            switch (stringDir.ToLower())
            {
                case "north":
                    MovePaint(posX, posY - distance);
                    break;

                case "south":
                    MovePaint(posX, posY + distance);
                    break;

                case "east":
                    MovePaint(posX + distance, posY);
                    break;

                case "west":
                    MovePaint(posX - distance, posY);
                    break;

            }
        }

        //moves the turtle and paints previous position if enabled
        public void MovePaint(int pX, int pY)
        {

            int minX = Math.Min(posX, pX);
            int maxX = Math.Max(posX, pX);

            int minY = Math.Min(posY, pY);
            int maxY = Math.Max(posY, pY);

            posX = Clamp(pX, 0, Board.boardArray.GetLength(0) - 1);
            posY = Clamp(pY, 0, Board.boardArray.GetLength(1) - 1);

            if (draw)
            {
                for (int x = 0; x < Board.boardArray.GetLength(0); x++)
                {
                    for (int y = 0; y < Board.boardArray.GetLength(1); y++)
                    {

                        if (x >= minX && x <= maxX)
                        {
                            if (y >= minY && y <= maxY)
                            {
                                Board.boardArray[x, y] = '0';
                            }
                        }
                    }
                }
            }
        }

        //clamp a value in between two other values
        public int Clamp(int value, int min, int max)
        {
            if (value > max)
            {
                return max;
            }
            if (value < min)
            {
                return min;
            }
            return value;
        }
    }
}
