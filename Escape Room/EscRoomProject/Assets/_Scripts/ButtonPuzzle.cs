using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPuzzle : MonoBehaviour {

    public ButtonPuzzle[] button = new ButtonPuzzle[3];
    public bool isOn = false;
    private AudioSource aSource;
    private float timeSincePress = 10.0f;
    private float time = 0;

	// Use this for initialization
	void Start ()
    {
        aSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(button[0].isOn == true && button[1].isOn == true && button[2].isOn == true)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Main Menu");
        }

        if (time > timeSincePress)
        {
            time = 0;
            isOn = false;
            //aSource.Play();
        }
    }

    public void ButtonOn()
    {
        time += Time.deltaTime;
        isOn = true;
    }
}
