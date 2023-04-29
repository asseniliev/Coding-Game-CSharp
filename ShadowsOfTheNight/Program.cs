using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * https://www.codingame.com/ide/puzzle/shadows-of-the-knight-episode-1
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // width of the building.
        int H = int.Parse(inputs[1]); // height of the building.
        int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
        inputs = Console.ReadLine().Split(' ');
        int X0 = int.Parse(inputs[0]);
        int Y0 = int.Parse(inputs[1]);

        int winX = X0;
        int winY = Y0;

        int xLeftBoundary = 0;
        int xRightBoundary = W;
        int yUpBoundary = 0;
        int yDownBoundary = H;
        

        // game loop
        while (true)
        {
            string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)

            foreach (char letter in bombDir)
            {
                switch(letter)
                {
                    case 'U':
                        yDownBoundary = winY;
                        winY = (winY + yUpBoundary) / 2;                        
                        break;
                    case 'D':
                        yUpBoundary = winY;
                        winY = (winY + yDownBoundary) / 2;
                        break;
                    case 'L':
                        xRightBoundary = winX;
                        winX = (winX + xLeftBoundary) / 2;
                        break;
                    case 'R':
                        xLeftBoundary = winX;
                        winX = (winX + xRightBoundary) / 2;
                        break;
                }
            }

            N--;
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");


            // the location of the next window Batman should jump to.
            Console.WriteLine($"{winX} {winY}");
        }
    }
}