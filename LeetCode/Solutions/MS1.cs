using System;

class Ms1
{
    public int solution(int[] A, int K)
    {
        Array.Sort(A);

        int N = A.Length;
        int third = N / 3;

        // The (N/3)th smallest element is at index third - 1
        // The (N/3)th largest element is at index 2*third - 1
        int smallestIndex = third - 1;
        int largestIndex = 2 * third - 1;

        // Try to move the smallest element down and largest element up
        while (K > 0)
        {
            // If the current smallest element is larger than the element right after it, try to decrease
            if (smallestIndex >= 0 && A[smallestIndex] < A[smallestIndex + 1] && K > 0)
            {
                A[smallestIndex]--;
                K--;
                smallestIndex--;
            }
            // If the current largest element is smaller than the element before it, try to increase
            else if (largestIndex < N && A[largestIndex] > A[largestIndex - 1] && K > 0)
            {
                A[largestIndex]++;
                K--;
                largestIndex++;
            }
            else
            {
                break;
            }
        }

        // Calculate the difference between the (N/3)th largest and smallest elements
        int smallest = A[third - 1];  // (N/3)th smallest element after sorting
        int largest = A[2 * third - 1];  // (N/3)th largest element after sorting

        return largest - smallest;
    }
}