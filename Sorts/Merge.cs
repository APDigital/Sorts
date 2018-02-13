using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class Merge
    {
        int[] merge(int[] A, int start, int mid, int end)
        {
            //stores the starting position of both parts in temporary variables.
            int p = start, q = mid + 1;
            int[] Arr = { end - start + 1 };
            int k = 0;

            for (int i = start; i <= end; i++)
            {
                if (p > mid)      //checks if first part comes to an end or not .
                    Arr[k++] = A[q++];

                else if (q > end)   //checks if second part comes to an end or not
                    Arr[k++] = A[p++];

                else if (A[p] < A[q])     //checks which part has smaller element.
                    Arr[k++] = A[p++];

                else
                    Arr[k++] = A[q++];
            }
            for (int j = 0; j < k; j++)
            {
                /* Now the real array has elements in sorted manner including both 
                     parts.*/
                A[start++] = Arr[j];
            }
            return Arr;
        }
       public void merge_sort(int[] A, int length)
        {
            if (A[0] < length)
            {
                int mid = (length) / 2;           // defines the current array in 2 parts .
                merge_sort(A, length - mid);                 // sort the 1st part of array .
                merge_sort(A, mid + length);              // sort the 2nd part of array.


                // merge the both parts by comparing elements of both the parts.
                merge(A, A[0], mid, A[length - 1]);
            }
        }

        //public int merge(int[] Left, int[] Right, int[] arr, int nL, int nR)
        //{
        //    int i = 0, j = 0, k = 0, inv = 0;

        //    while (i < nL && j < nR)
        //    {
        //        if (Left[i] <= Right[j])
        //        {
        //            arr[k++] = Left[i++];
        //        }
        //        else
        //        {
        //            arr[k++] = Right[j++];
        //            inv += (nL - i);
        //        }
        //    }

        //    while (i < nL)
        //    {
        //        arr[k++] = Left[i++];
        //    }

        //    while (j < nR)
        //    {
        //        arr[k++] = Right[j++];
        //    }
        //    return inv;
        //}
        //public int MergeSort(int[] arr, int length)
        //{
        //    if (length < 2) return 0;
        //    int mid = length / 2;
        //    int nL = mid;
        //    int nR = (length - mid);

        //    //left is the first half of the array
        //    int[] Left = {nL};
        //    //right is the second half of the array
        //    int[] Right = {nR};


        //    for (int i = 0; i < nL; i++)
        //    {
        //        Left[i] = arr[i];
        //    }
        //    for (int i = nL; i < length; i++)
        //    {
        //        Right[i - mid] = arr[i];
        //    }

        //    int  x = MergeSort(Left, nL);
        //    int y = MergeSort(Right, nR);
        //    int z = merge(Left, Right, arr, nL, nR);
        //    return x + y + z;
        //}
        ////int arr[5000005];

    }
}
