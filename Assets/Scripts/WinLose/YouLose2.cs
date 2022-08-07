using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class YouLose2 : MonoBehaviour
{
    private void ReloadLevel()
    {
        SceneManager.LoadScene(7);
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
