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
        RaycastHit hit;
        Ray look = new Ray(player.position, player.forward);
        Debug.DrawRay(player.position, player.forward * 2);

        if (Physics.Raycast(look, out hit, 2))
        {

            if(hit.collider.tag == "Light")
            {
                promptText.text = "This is a light!";
                promptUI.SetActive(true);
            }
            else
            {
                promptText.text = "";
                promptUI.SetActive(false);
            }
        }
	}
}
