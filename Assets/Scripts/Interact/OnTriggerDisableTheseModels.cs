using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerDisableTheseModels : MonoBehaviour
{
    public GameObject barrier_01;
    public GameObject barrier_02;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("TRIGGER ENTER");
            barrier_01.gameObject.SetActive(false);
            barrier_02.gameObject.SetActive(false);

        }
    }

}

