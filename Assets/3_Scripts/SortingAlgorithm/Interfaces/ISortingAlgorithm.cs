using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISortingAlgorithm
{
    public void Sort(List<Bar> willSortedList);
    public int[] AddValueInArray(List<Bar> willSortedBarList);
    public void WriteSortedList(List<Bar> willSortedBarList, int[] willSorted);
}
