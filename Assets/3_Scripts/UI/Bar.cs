using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    [SerializeField] private Image barImage;
    [SerializeField] private TextMeshProUGUI barValueText;
    public int barValue;
    
    void OnEnable()
    {
        barValue = Random.Range(1,101);
    }

    void FixedUpdate()
    {
        float x = barValue;
        barImage.fillAmount = Mathf.Lerp(barImage.fillAmount, x / 100, 7f*Time.deltaTime);
        barValueText.text = barValue.ToString();
    }
}
