using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1,3,5,2,4};
        QuickSort(arr, 0, arr.Length - 1);
        Console.WriteLine(string.Join(" ", arr));
    }

    static void QuickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = arr[right], i = left - 1;
            for (int j = left; j < right; j++)
                if (arr[j] <= pivot) (arr[++i], arr[j]) = (arr[j], arr[i]);

            (arr[i + 1], arr[right]) = (arr[right], arr[i + 1]);
            int pivotIndex = i + 1;

            QuickSort(arr, left, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, right);
        }
    }
}