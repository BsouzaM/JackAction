using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : InteractBehaviour
{
    public GameObject sceneTrigger;

    public override void OnInteract()
    {
        SceneManager.LoadScene(0);
    }
}