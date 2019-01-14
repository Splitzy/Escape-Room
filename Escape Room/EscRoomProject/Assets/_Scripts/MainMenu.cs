﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("EscapeRoom");
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
