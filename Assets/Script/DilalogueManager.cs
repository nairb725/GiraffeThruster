using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DilalogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public string[] dialogueLines;
    private int currentLine = 0;

    void Start()
    {
        dialogueText.text = dialogueLines[currentLine];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentLine < dialogueLines.Length - 1)
            {
                currentLine++;
                dialogueText.text = dialogueLines[currentLine];
            }
            else
            {
                dialogueText.text = "";
            }
        }
    }
}
