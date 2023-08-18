using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootLoader : MonoBehaviour
{
    [SerializeField] private Transform panelParent;
    [SerializeField] private AlgorithmData algorithmData;

    private void Start()
    {
        CreateGameLevel();
    }

    public void CreateGameLevel()
    {
        Instantiate(algorithmData.algorithmPrefab, panelParent);
    }
}
