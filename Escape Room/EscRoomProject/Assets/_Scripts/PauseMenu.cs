using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    [SerializeField]
    private GameObject pauseUI;

    public static bool isPaused = false;

    public UnityEvent onPause = new UnityEvent();
    public UnityEvent onUnPause = new UnityEvent();

    // Update is called once per frame

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }

    void Update()
    {

		if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused == true)
            {
                Resume();
            }
            else if (isPaused == false)
            {
                Pause();
            }
        }
	}

    public void Resume()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        onUnPause.Invoke();
    }

    public void Pause()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        onPause.Invoke();
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }
}
