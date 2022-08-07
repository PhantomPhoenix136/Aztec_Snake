using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class YouWin2 : MonoBehaviour
{
    public GameObject VictoryScreen;

    public void NextLvl()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Debug.Log("Выход");
        Application.Quit();
    }
}


