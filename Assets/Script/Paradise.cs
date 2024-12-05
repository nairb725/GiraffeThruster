using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Paradise : MonoBehaviour
{
    public Timer timerScript;
    public GameObject winText;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Girafe"))
        {
            win();
        }
    }

    public void win()
    {
        winText.SetActive(true);
        float currentTime = timerScript.GetElapsedTime();

        float bestTime = PlayerPrefs.GetFloat("BestTime", float.MaxValue);

        if (currentTime < bestTime)
        {
            PlayerPrefs.SetFloat("BestTime", currentTime);
            PlayerPrefs.Save(); // Sauvegarder les données
        }
    }
}
