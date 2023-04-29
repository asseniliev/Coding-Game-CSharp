using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
/**
 * https://www.codingame.com/ide/puzzle/power-of-thor
 * Solve this puzzle by writing the shortest code.
 * Whitespaces (spaces, new lines, tabs...) are counted in the total amount of chars.
 * These comments should be burnt after reading!
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int LX = int.Parse(inputs[0]); // the X position of the light of power
        int LY = int.Parse(inputs[1]); // the Y position of the light of power
        int TX = int.Parse(inputs[2]); // Thor's starting X position
        int TY = int.Parse(inputs[3]); // Thor's starting Y position

        // game loop
        while (LX != TX || LY != TY)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The level of Thor's remaining energy, representing the number of moves he can still make.

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            if (TY < LY)
            {
                TY++;
                Console.Write("S");
            }
            else if (TY > LY)
            {
                TY--;
                Console.Write("N");
            }

            if (TX < LX)
            {
                TX++;
                Console.Write("E");
            }
            else if (TX > LX)
            {
                TX--;
                Console.Write("W");
            }

            Console.Write("\n");
            remainingTurns--;
            // A single line providing the move to be made: N NE E SE S SW W or NW
        }
    }
}