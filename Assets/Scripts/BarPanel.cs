using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarPanel : MonoBehaviour
{
    List<Bar> sortingList = new List<Bar>();
    int[] willSorted;
    [Range(0, 152)]
    [SerializeField] int howManyBar;
    [SerializeField] GameObject uiBar;


    void Start()
    {
        for (var i = 0; i < howManyBar; i++)
        {
            var obj = Instantiate(uiBar, transform.position, Quaternion.identity);
            sortingList.Add(obj.GetComponent<Bar>());
            obj.transform.SetParent(this.transform);
        }
        //Sort(willSorted);
        //WriteNumList(willSorted);
    }

    void AddValueInArray()
    {
        List<int> numList = new List<int>();
        for (var a = 0; a < sortingList.Count; a++)
        {
            numList.Add(sortingList[a].value);
        }
        willSorted = numList.ToArray();
    }

    public void BubbleSort()
    {
        AddValueInArray();
        int i = 1, j, currentValue;
        int arrayLength = willSorted.Length;
        while (i < arrayLength)
        {
            j = arrayLength - 1;
            while (j >= 1)
            {
                if (willSorted[j - 1] > willSorted[j])
                {
                    currentValue = willSorted[j];
                    willSorted[j] = willSorted[j - 1];
                    willSorted[j - 1] = currentValue;
                }
                j--;
            }
            i++;
        }
        WriteNumList();
    }

    public void QuickSort()
    {
        AddValueInArray();
        
    }
    public void WriteNumList()
    {
        for (int i = 0; i < sortingList.Count; i++)
        {
            //print(willSorted[i]);
            sortingList[i].value = willSorted[i];
        }
    }
}
