using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public bool GameStat = false;

    public void PauseGame()
    {
        if (GameStat == false)
        {
            Time.timeScale = 0f;
            GameStat = true;
        }
        else
        {
            Time.timeScale = 1f;
            GameStat = false;
        }
    }
}
