using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private static Animator anim;
    private static Animation animDoor;

    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
        animDoor = GetComponent<Animation>();
	}
	
	
    public static void DoorOpen()
    {
        anim.SetBool("isOpen", true);
        animDoor["DoorOpen"].wrapMode = WrapMode.ClampForever;
        animDoor.Play("DoorOpen");
    }


}
