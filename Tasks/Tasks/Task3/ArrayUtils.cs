using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task3
{
    internal class ArrayUtils
    {
        private void Swap<T>(ref T first ,ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }
        public void ReverseArray<T>(T[] array)
        {
            if (array.Length < 1)
                return;

            int j = array.Length - 1;
            int arrMid ;
            if (j % 2 == 0)
                arrMid = j / 2;
            else
                arrMid = (j / 2) + 1;
            for(int i =0; i< arrMid; i++)
            {
                Swap(ref array[i], ref array[j]);
                j--;
            }
        }

        public T FindMax<T>(T[] arr) where T : IComparable<T>
        {
            if (arr == null)
                throw new ArgumentNullException(nameof(arr), "Array cannot be null.");

            if (arr.Length == 0)
                throw new ArgumentException("Array cannot be empty.", nameof(arr));

            Array.Sort(arr);
            T maximum = arr[arr.Length-1];

            return maximum;

        }
    }
}
