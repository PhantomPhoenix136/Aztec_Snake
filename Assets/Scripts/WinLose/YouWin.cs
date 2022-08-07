using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class YouWin : MonoBehaviour
{
    public GameObject VictoryScreen;

    public void NextLvl()
    {
        SceneManager.LoadScene(4);
    }
    public void ExitGame()
    {
        Debug.Log("Выход");
        Application.Quit();
    }
}


