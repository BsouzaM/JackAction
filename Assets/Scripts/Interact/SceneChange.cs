using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : InteractBehaviour
{

    public override void OnInteract()
    {
        SceneManager.LoadScene(0);
    }
}