using System.Collections.Generic;
using UnityEngine;

namespace SortingAlgorithms
{
    public class BubbleSort : ISortingAlgorithm
    {
        public void Sort(List<Bar> willSortedBarList)
        {
            int[] willSorted = AddValueInArray(willSortedBarList);

            int arrayLength = willSorted.Length;

            for (int i = 1; i < arrayLength; i++)
            {
                for (int j = arrayLength - 1; j >= 1; j--)
                {
                    if (willSorted[j - 1] > willSorted[j])
                    {
                        (willSorted[j], willSorted[j - 1]) = (willSorted[j - 1], willSorted[j]);
                    }
                }
            }

            WriteSortedList(willSortedBarList, willSorted);
        }

        public int[] AddValueInArray(List<Bar> willSortedBarList)
        {
            var numList = new List<int>();
            foreach (var t in willSortedBarList)
            {
                numList.Add(t.barValue);
            }
            return numList.ToArray();
        }

        public void WriteSortedList(List<Bar> willSortedBarList, int[] willSorted)
        {
            for (int i = 0; i < willSortedBarList.Count; i++)
            {
                willSortedBarList[i].barValue = willSorted[i];
            }
        }
    }
}
