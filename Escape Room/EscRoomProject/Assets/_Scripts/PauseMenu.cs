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



	// Use this for initialization
	void Start()
    {
		
	}
	
	// Update is called once per frame
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
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Debug.Log("Unpausing Menu...");
        Debug.Log(Time.timeScale);
        onUnPause.Invoke();
    }

    public void Pause()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        Debug.Log("Pausing Menu...");
        Debug.Log(Time.timeScale);
        onPause.Invoke();
    }

    public void LoadMainMenu()
    {
        //Time.timeScale = 1f;
        //SceneManager.LoadScene("MainMenu");
    }
}
