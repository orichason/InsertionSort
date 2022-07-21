using System;
using System.Collections.Generic;

namespace InsertionSort
{
    class Program
    {
        static void InsertionSort(List<int> UnsortedList)
        {
            int temp;

            for (int i = 1; i < UnsortedList.Count; i++)
            {
                if (UnsortedList[i] > UnsortedList[i - 1])
                {
                    for (int y = i; i < 0; y++)
                    {
                        if(UnsortedList[i] < UnsortedList[y])
                        {
                            temp = UnsortedList[i];
                            UnsortedList[y] = temp;
                            UnsortedList[i] = UnsortedList[y];
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            List<int> List = new List<int> { 4, 9, 1, 43, 22, 10 };

            InsertionSort(List);
        }
    }
}
