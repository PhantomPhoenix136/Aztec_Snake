using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class YouLose1 : MonoBehaviour
{
    private void ReloadLevel()
    {
        SceneManager.LoadScene(4);
    }
    public void Lose()
    {
        ReloadLevel();
    }
    public void ExitGame()
    {
        Debug.Log("Выход");
        Application.Quit();
    }
}
