using System;

class Task23
{
    public static int n;
    static void Main()
    {
        Console.Write("Enter N: ");
        n = Int32.Parse(Console.ReadLine());

        Console.Write("Enter K: ");
        int k = Int32.Parse(Console.ReadLine());

        int[] arr = new int[k];

        recSolution(arr, 0);
    }
    static void recSolution(int[] array, int index)
    {
        if (index != array.Length)
            for (int i = 1; i <= n; i++)
            {
                array[index] = i;
                recSolution(array, index + 1);
            }
        else
        {
            for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
            Console.WriteLine();
        }
    }
}

