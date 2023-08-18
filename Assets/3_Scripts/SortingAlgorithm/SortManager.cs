using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SortingAlgorithms
{
    public class SortManager : MonoBehaviour
    {
        [SerializeField] private Transform barParent;
        [SerializeField] GameObject uiBar;
        private List<Bar> willSortingList = new List<Bar>(36);

        private void Start()
        {
            for (var i = 0; i < willSortingList.Capacity; i++)
            {
                willSortingList
                    .Add(
                    Instantiate(uiBar, transform.position, Quaternion.identity, barParent)
                        .GetComponent<Bar>()
                        );
            }
        }

        public void BubbleSortAlgorithm()
        {
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Sort(willSortingList);
        }
    }
}
