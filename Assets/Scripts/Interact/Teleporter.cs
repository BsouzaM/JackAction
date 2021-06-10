using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    public GameObject teleporter;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Se ele entrar no trigger do jack, teleporta para o player para o local
            React();
        }
    }
    
    void React()
    {
        // Coordenadas do World Space
        teleporter.transform.position = new Vector3(0, 7, 2);
    }
    
}