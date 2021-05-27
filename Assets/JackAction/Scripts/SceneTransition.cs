using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            SceneManager.LoadScene("JA_House_Interior");

        if (Input.GetKeyDown(KeyCode.L))
            SceneManager.LoadScene("JA_Supermarket_Interior");
    }
}
