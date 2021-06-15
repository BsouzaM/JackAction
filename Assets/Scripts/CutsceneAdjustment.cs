using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneAdjustment : MonoBehaviour
{
    public List<GameObject> DeactivateOnPlay = new List<GameObject>();
    void Start()
    {
        if(SceneManager.GetActiveScene().name == "Cutscene")
        foreach(GameObject este in DeactivateOnPlay)
        {
            este.SetActive(false);
        }
    }

}
