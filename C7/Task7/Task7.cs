using System;

class Task7
{
    static void Main()
    {
        int sum = 0;

        Console.Write("Enter N: ");
        int n = Int32.Parse(Console.ReadLine());
        Console.Write("Enter K (K < N): ");
        int k = Int32.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter {0} element: ", i);
            arr[i] = Int32.Parse(Console.ReadLine());
        }

        Array.Sort(arr, (a, b) => b.CompareTo(a));

        for (int i = 0; i < k; i++) sum += arr[i];

        Console.WriteLine("\nBiggest sum is {0}", sum);
    }
}

