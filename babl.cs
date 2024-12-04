﻿using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 3, 5, 2, 4 };

        BubbleSort(array);


        foreach (int num in array)
        {
            Console.Write(num + "|");
        }
        Console.ReadLine();
    }
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];

                    arr[j] = arr[j + 1];

                    arr[j + 1] = temp;
                }
            }
        }
    }
}
