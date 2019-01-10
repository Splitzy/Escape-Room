using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayCastTest : MonoBehaviour {
    public Transform player;
    public Text promptText;
    public GameObject promptUI;


    void Update()
    {
        promptUI.SetActive(false);
        RaycastHit hit;
        Ray look = new Ray(player.position, player.forward);
        Debug.DrawRay(player.position, player.forward * 2);

        if (Physics.Raycast(look, out hit, 2))
        {
            if(hit.collider.CompareTag("Light"))
            {
                promptText.text = "This is a light!";
                promptUI.SetActive(true);

                if(Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.SendMessage("TurnOff");
                }
            }
            else if (hit.collider.CompareTag("Button"))
            {
                promptText.text = "This is a button!";
                promptUI.SetActive(true);

                if(Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("Button has been pressed");
                    hit.collider.SendMessage("ButtonOn");
                }
            }
        }
	}
}
