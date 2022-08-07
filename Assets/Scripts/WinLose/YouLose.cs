using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class YouLose : MonoBehaviour
{
    private void ReloadLevel1()
    {
        SceneManager.LoadScene(1);
    }
    public void Lose()
    {
        ReloadLevel1();
    }
    public void ExitGame()
    {
        Debug.Log("Выход");
        Application.Quit();
    }
}
