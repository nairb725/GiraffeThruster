using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float elapsedTime = 0f; // Temps écoulé
    public TextMeshProUGUI timerText; // Référence au composant TextMeshPro

    private bool timerIsRunning = true;

    void Start()
    {
        elapsedTime = 0f;
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            elapsedTime += Time.deltaTime;
            UpdateTimerText(elapsedTime);
        }
    }

    void UpdateTimerText(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
