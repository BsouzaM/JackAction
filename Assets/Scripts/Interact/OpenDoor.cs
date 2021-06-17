using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class OpenDoor : InteractBehaviour
{
    public override void OnInteract()
    {
        Debug.Log("Interact Success");
        rotate();
        gameObject.GetComponent<OpenDoor>().enabled = false;
    }

    void rotate()
    {
        transform.eulerAngles = Vector3.up * 90;
    }
}
