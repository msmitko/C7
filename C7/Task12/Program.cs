using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter height: ");
        int y = Int32.Parse(Console.ReadLine());

        Console.Write("Enter width: ");
        int x = Int32.Parse(Console.ReadLine());

        int a = 0;

        for (int i = 1; i <= y; i++)
        {
            Console.Write("{0} ", i);

            a += i;

            for (int j = 1; j < x; j++)
            {
                a += y;
                Console.Write("{0} ", a);
            }

            a = 0;
            Console.WriteLine();
        }
        Console.WriteLine("Enter matrix size: ");
        int n = Int32.Parse(Console.ReadLine());

        int[,] arr = new int[n, n];
        arr[0, 0] = 1;

        for (int i = 1; i < arr.GetLength(0); i++)
            if (i % 2 == 1) arr[0, i] = arr[0, i - 1] + n * 2 - 1;
            else arr[0, i] = arr[0, i - 1] + 1;

        for (int i = 1; i < arr.GetLength(0); i++)
            for (int j = 0; j < arr.GetLength(1); j++)
                if (j % 2 == 1) arr[i, j] = arr[i - 1, j] - 1;
                else arr[i, j] = arr[i - 1, j] + 1;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++) Console.Write("{0, 4}", arr[i, j]);
            Console.WriteLine();
        }
        Console.Write("Enter arr size: ");
        int length = Int32.Parse(Console.ReadLine());

        int[,] ar = new int[length, length];
        ar[length - 1, 0] = 1;
        int counter = 1;
        for (int row = length - 2; row >= 0; row--)
        {
            ar[row, 0] = ar[row + 1, 0] + counter;
            int newRow = row;
            for (int diagonal = 1; diagonal <= counter; diagonal++)
            {
                ar[newRow + 1, diagonal] = ar[newRow, diagonal - 1] + 1;
                newRow++;
            }
            counter++;
        }

        ar[0, length - 1] = length * length;
        int diagonalLength = 2;
        int posX = 1;
        int posY = length - 1;
        int prevX = 0;
        int prevY = length - 1;

        for (int i = 1; i < counter - 1; i++)
        {
            for (int j = 1; j <= diagonalLength; j++)
            {
                ar[posX, posY] = ar[prevX, prevY] - 1;
                prevX = posX;
                prevY = posY;
                posX--;
                posY--;
            }
            diagonalLength++;
            posX = i + 1;
            posY = length - 1;
        }

        for (int i = 0; i < ar.GetLength(0); i++)
        {
            for (int j = 0; j < ar.GetLength(1); j++) Console.Write("{0, 4}", ar[i, j]);
            Console.WriteLine();
        }
        Console.Write("Enter arr size: ");
        int lngth = Int32.Parse(Console.ReadLine());

        int[,] arrr = new int[lngth, lngth];
        int numConcentricSquares = (int)Math.Ceiling((lngth) / 2.0);
        int sideLen = lngth;
        int currNum = 0;

        for (int i = 0; i < numConcentricSquares; i++)
        {

            for (int j = 0; j < sideLen; j++) ar[i + j, i] = ++currNum;

            for (int j = 1; j < sideLen - 1; j++) ar[lngth - 1 - i, i + j] = ++currNum;

            for (int j = sideLen - 1; j > 0; j--) ar[i + j, lngth - 1 - i] = ++currNum;

            for (int j = sideLen - 1; j > 0; j--) ar[i, i + j] = ++currNum;

            sideLen -= 2;
        }


        for (int i = 0; i < ar.GetLength(0); i++)
        {
            for (int j = 0; j < ar.GetLength(1); j++) Console.Write("{0, 4}", ar[i, j]);
            Console.WriteLine();
        }
    }
}

