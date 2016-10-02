/*******************************************************
Turtle Graphics
By Justin Buttrey
Program to create a bord and allow turtle to move on it
********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics
{
    class Game
    {
        static void Main(string[] args)
        {

            bool draw = false;
            char delimeter = ' ';//use space a delimiter for input
            int sizeX,
                sizeY,
                distance;

            Console.WriteLine("Insert board dimensions, minimum 5x5");

            //get board size
            while (true)
            {
                Console.Write("Board Width: ");
                if (Int32.TryParse(Console.ReadLine(), out sizeX))
                {
                    if (sizeX >= 5)
                    {
                        Console.Write("Board Height: ");
                        if (Int32.TryParse(Console.ReadLine(), out sizeY))
                        {
                            if (sizeY >= 5)
                            {
                                break;
                            }
                        }
                    }
                }
            }

            //create new board and turtle
            Board board = new Board(sizeX, sizeY);
            Turtle turtle = new Turtle();

            while (true)
            {
                //clear the board
                Console.Clear();

                //redraw the gameboard
                board.DrawBoard(turtle.posX, turtle.posY, turtle.symbol);

                //draw text on screen
                DrawText(draw);

                //get input
                string[] input = Console.ReadLine().Split(delimeter);

                switch (input[0].ToLower())
                {
                    //draw command
                    case "draw":
                        draw = !draw;
                        break;

                    //exit program
                    case "exit":
                    case "quit":
                        Environment.Exit(0);
                        break;

                    //clean board
                    case "reset":
                        board.InitBoard();
                        break;
                }

                //reset move distance
                distance = 1;

                //parse move command
                if (input.Length > 1 && Int32.TryParse(input[1], out distance))
                {
                    //do not allow move distance less than 1
                    if (distance < 1)
                    {
                        distance = 1;
                    }
                }

                //move turtle
                turtle.UpdatePosition(input[0], distance, draw);
            }
        }

        static void DrawText(bool draw)
        {

            Console.WriteLine();

            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("Commands:");

            Console.WriteLine("North South East West + Distance (Example: North 10)");

            Console.WriteLine("Draw");

            Console.WriteLine("Exit  or  Quit");

            Console.WriteLine("-");
            Console.WriteLine("Drawing: " + draw);
            Console.WriteLine("-");

            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine();

        }
    }
}
