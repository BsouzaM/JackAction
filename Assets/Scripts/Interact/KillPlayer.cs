using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : InteractBehaviour
{
    public GameObject GameOverScreen;
    public override void OnInteract()
    {
        FindObjectOfType<PlayerMovement>().enabled = false;
        FindObjectOfType<MouseLook>().enabled = false;
        GameOverScreen.SetActive(true);
    }
}
