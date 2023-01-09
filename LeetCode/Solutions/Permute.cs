using System;

namespace LeetCode.Solutions
{
    internal class PermuteDemo
    {

        public void start()
        {
            int[] arr = { 1, 2, 3 };
            Permute(arr, 0, arr.Length - 1);
        }
        public void Permute(int[] arr, int start, int end)
        {
            if (start == end)
            {
                Console.WriteLine(string.Join(", ", arr));
                return;
            }
            for (int i = start; i <= end; i++)
            {
                swap(arr, start, i);
                Permute(arr, start + 1, end);
                swap(arr, start, i);
            }

        }

        public void swap(int[] arr, int i, int j)
        {
            (arr[j], arr[i]) = (arr[i], arr[j]);
        }
    }
}
