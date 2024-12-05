using UnityEngine;
using TMPro;

public class Paradise : MonoBehaviour
{
    public Timer timerScript;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Girafe"))
        {
            win();
        }
    }

    public void win()
    {
        float currentTime = timerScript.GetElapsedTime();

        float bestTime = PlayerPrefs.GetFloat("BestTime", float.MaxValue);

        if (currentTime < bestTime)
        {
            PlayerPrefs.SetFloat("BestTime", currentTime);
            PlayerPrefs.Save(); // Sauvegarder les données
        }
    }
}
