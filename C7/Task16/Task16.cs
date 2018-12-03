using System;

class Task16
{
    static void Main()
    {
        Console.Write("Enter array length: ");
        int length = Int32.Parse(Console.ReadLine());

        int[] arr = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("Enter {0} element: ", i);
            arr[i] = Int32.Parse(Console.ReadLine());
        }

        Console.Write("Enter searched number: ");
        int number = Int32.Parse(Console.ReadLine());

        int index = Array.BinarySearch(arr, number);

        if (index >= 0) Console.Write("Number is on {0} index.", index);
        else Console.Write("Number wasn't found.");
    }
}

