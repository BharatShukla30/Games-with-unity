using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelmanager : MonoBehaviour
{
    public void Loada(string name)
    {
        Application.LoadLevel(name);
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void LoadNextlevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
    public void brickDestroyed()
    {
        if(brick.breakableCount<=0)
        {
            LoadNextlevel();
        }
    }
}