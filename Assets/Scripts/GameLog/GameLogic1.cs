using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic1 : MonoBehaviour
{
    public Controls Controls;
    public MainScreen MainScreen;
   public enum Status
    {
        Play,
        Lose,
        Win
    }
    public Status CurrentStatus { get; private set; }

    public void OnDeath()
    {
        if (CurrentStatus != Status.Play) return;

        CurrentStatus = Status.Lose;
        Controls.Player.gameObject.SetActive(false);
        MainScreen.gameObject.SetActive(false);
        SceneManager.LoadScene(5);
    }
    public void OnWin()
    {
        if (CurrentStatus != Status.Play) return;

        CurrentStatus = Status.Win;
        Controls.Player.gameObject.SetActive(false);
        MainScreen.gameObject.SetActive(false);
        SceneManager.LoadScene(6);
    }
}
