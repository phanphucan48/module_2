using System;
using System.Collections.Generic;
using System.Text;

namespace TimKiem
{
    public class Timkiem
    {
        public int[] CreateArray(int n)
        {
            Random random = new Random();
            int[] result = new int[n];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = random.Next(30, 60);
            }
            return result;
        }
        public bool IsSymmetryArray(int[] array)
        {

            int first = 0, last = array.Length - 1;
            while (first < last)
            {
                if (array[first] != array[last]) return false;
                first++;
                last--;
            }
            return true;
        }
        public void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                double currentMin = array[i];
                int currentMinIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (currentMin > array[j])
                    {
                        currentMin = array[j];
                        currentMinIndex = j;
                        int temp = array[currentMinIndex];
                        array[currentMinIndex] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array;
        }
        public bool IsSorted(int[] arr, int tanghoacgiam)
        {
            if (tanghoacgiam == 1)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] >= arr[i + 1])
                    {
                        return false;
                    }
                }
                return true;
            }
            else if (tanghoacgiam == -1)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] <= arr[i + 1])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        public string Find(int[] arr,int number)
        {
            if (IsSorted(arr,1) || IsSorted(arr,-1))
            { // phuong thuc tim kiem nhi phan 
                int low = 0;
                int high = arr.Length - 1;
                while (high > low)
                {
                    int mid = (high + low) / 2;
                    if (number < arr[mid])
                    {
                        high = mid - 1;
                    }
                    else if (number == arr[mid])
                    {
                        return $"{mid}";
                    }
                    else
                    {
                        low = mid + 1;
                    }
                    return "Not found!";
                }
            } 
            return "This array hasn't been sorted!";
        }
    }
}
