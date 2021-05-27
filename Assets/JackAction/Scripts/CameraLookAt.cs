using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    public Transform player;
    public Camera cam;
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
    }
}
