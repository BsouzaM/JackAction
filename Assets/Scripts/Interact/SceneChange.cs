using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public GameObject sceneTrigger;
    void OnTriggerEnter(Collider other)
    {
        // Se ele entrar no trigger do supermarket, muda de scene
        if (other.gameObject.tag == "Player") SceneManager.LoadScene(0);
    }
}