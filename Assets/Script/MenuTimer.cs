using UnityEngine;
using TMPro;

public class MenuTimer : MonoBehaviour
{
    public TextMeshProUGUI bestTimeText;

    void Start()
    {
        float bestTime = PlayerPrefs.GetFloat("BestTime", float.MaxValue);

        if (bestTime == float.MaxValue)
        {
            bestTimeText.text = "Paradise reach in : ";
        }
        else
        {
            bestTimeText.text = "Paradise reach in : " + bestTime.ToString("F2") + " secondes";
        }
    }
}
