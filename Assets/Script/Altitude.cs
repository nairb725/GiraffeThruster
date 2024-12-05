using UnityEngine;
using TMPro;

public class Altitude : MonoBehaviour
{
    public TextMeshProUGUI heightText;
    public Transform player;
    private float height;

    void Update()
    {
        height = player.position.y;

        heightText.text = "Altitude: " + height.ToString("F2") + "m";
    }
}
