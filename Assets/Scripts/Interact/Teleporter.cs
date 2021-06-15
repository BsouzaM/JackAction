using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class Teleporter : InteractBehaviour
{
    private GameObject teleporter;
    public GameObject Destiny;

    private void Start()
    {
        teleporter = FindObjectOfType<PlayerMovement>().gameObject;
    }
    public override void OnInteract()
    {
        teleporter.transform.position = Destiny.transform.position;
    }
}