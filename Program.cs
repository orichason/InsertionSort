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
                if (UnsortedList[i] < UnsortedList[i - 1])
                {
                    for (int y = i; y >= 1; y--)
                    {
                        if (UnsortedList[y] < UnsortedList[y - 1])
                        {
                            temp = UnsortedList[y];
                            UnsortedList[y] = UnsortedList[y - 1];
                            UnsortedList[y - 1] = temp;
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            List<int> List = new List<int> { 54, 26, 93, 17, 77, 31, 44, 55, 20};

            InsertionSort(List);
        }
    }
}
