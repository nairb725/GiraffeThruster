using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceneManagerMain : MonoBehaviour
{
    public void Restart()
    {

        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
