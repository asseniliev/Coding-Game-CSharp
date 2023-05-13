using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Don't let the machines win. You are humanity's last hope...
 **/
class Player
{
    static int width = 0;
    static int height = 0;
    static char[,] grid;

    static void Main(string[] args)
    {
        Player.width = int.Parse(Console.ReadLine()); // the number of cells on the X axis
        Player.height = int.Parse(Console.ReadLine()); // the number of cells on the Y axis

        Player.grid = new char[width, height];

        for (int y = 0; y < height; y++)
        {
            string line = Console.ReadLine(); // width characters, each either 0 or .
            for (int x = 0; x < line.Length; x++)
            {
                grid[x, y] = line[x];
            }
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (grid[x, y] != '.')
                    Console.WriteLine($"{x} {y} {getRightNeighbour(x, y)} {getBottomNeighbour(x, y)}");
            }
        }

    }

    static string getRightNeighbour(int posX, int posY)
    {
        for (int x = posX + 1; x < Player.width; x++)
        {
            if (Player.grid[x, posY] != '.')
                return $"{x} {posY}";
        }

        return "-1 -1";
    }

    static string getBottomNeighbour(int posX, int posY)
    {
        for (int y = posY + 1; y < height; y++)
        {
            if (Player.grid[posX, y] != '.')
                return $"{posX} {y}";
        }

        return "-1 -1";
    }
}