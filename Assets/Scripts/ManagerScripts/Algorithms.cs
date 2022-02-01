using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Algorithm", menuName = "Algorithms/Algorithms", order = 1)]
public class Algorithms : ScriptableObject
{
    public GameObject algorithmPrefab;
    public GameObject currentAlgorithm;
    public void Load()
    {
        if (algorithmPrefab != null) currentAlgorithm = Instantiate(algorithmPrefab) as GameObject;
    }
}
