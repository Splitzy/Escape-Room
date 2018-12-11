using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPuzzle : MonoBehaviour
{
    public Light[] LightsComplete = new Light[4];
    public Light[] LightsOnOff;
    private bool isOff = true;
    public GameObject wall;
    private AudioSource aSource;

    public void TurnOff()
    {
        for (int i = 0; i < LightsOnOff.Length; i++)
        {
            if(isOff == false)
            {
                LightsOnOff[i].intensity = 0;
                isOff = true;
                Debug.Log("Turned on");
                aSource.Play();
            }
            else
            {
                LightsOnOff[i].intensity = 1;
                isOff = false;
                Debug.Log("Turned off");
                aSource.Play();
            }

        }
    }

    public void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    public void Update()
    {
        if(LightsComplete[0].intensity == 1 && LightsComplete[1].intensity == 1 && LightsComplete[2].intensity == 1 && LightsComplete[3].intensity == 1)
        {
            Destroy(wall);
        }
    }


}
