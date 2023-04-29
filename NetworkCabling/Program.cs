using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * https://www.codingame.com/ide/puzzle/network-cabling
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        long cableLength;
        int minX = int.MaxValue;
        int minY = int.MaxValue;
        int maxX = int.MinValue;
        int maxY = int.MinValue;

        int[] yLocations = new int[N];

        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int X = int.Parse(inputs[0]);
            int Y = int.Parse(inputs[1]);

            yLocations[i] = Y;

            if (X > maxX) maxX = X;
            if (Y > maxY) maxY = Y;

            if (X < minX) minX = X;
            if (Y < minY) minY = Y;
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        cableLength = maxX - minX;
        int median = medianValue(yLocations);

        for (int house = 0; house < N; house++)
        {
            cableLength += Math.Abs(yLocations[house] - median);
        }

        Console.WriteLine(cableLength);
    }

    private static int medianValue(int[] arr)
    {
        int len = arr.Length;
        Array.Sort(arr);

        int medianIndex = len / 2;
        int median;

        if (len % 2 == 0)
        { // array length is even
            median = (arr[medianIndex - 1] + arr[medianIndex]) / 2;
        }
        else
        { // array length is odd
            median = arr[medianIndex];
        }

        return median;
    }
}