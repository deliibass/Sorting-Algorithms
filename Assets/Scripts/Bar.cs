using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    public TextMeshProUGUI numTxt;
    public int value;
    public Image barImage;
    void Start()
    {
        value = Random.Range(1,101);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = value;
        barImage.fillAmount = Mathf.Lerp(barImage.fillAmount, x/100, 7f*Time.deltaTime);
        //barImage.fillAmount = x/100;
        numTxt.text = x.ToString();
    }
}
