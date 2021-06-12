using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class Teleporter : MonoBehaviour
{
    public GameObject teleporter;
    public bool firstFloor;
    public bool secondFloor;
    public bool garage;
    private Controls _Controls;
    private bool inside = false;

    private void OnEnable()
    {
        _Controls = new Controls();
        _Controls.Player.Interact.performed += InteractWithMe;
        _Controls.Player.Interact.Enable();
    }

    private void OnDisable()
    {
        _Controls.Player.Interact.performed -= InteractWithMe;
        _Controls.Player.Interact.Disable();
    }

    private void InteractWithMe(InputAction.CallbackContext obj)
    {
        if (inside)
        {
            if (firstFloor == true && secondFloor == false)
                // Se o player entrar no trigger e pressionar E, teleporta para o player para o primeiro andar.
                FirstFloor();
            if (secondFloor == true && firstFloor == false)
                // Se o player entrar no trigger e pressionar E, teleporta para o player para o segundo andar.
                SecondFloor();
            if (secondFloor == false && firstFloor == false && garage == true)
                // Se o player entrar no trigger e pressionar E, teleporta para o player para a garagem.
                Garage();
        }
    }
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.CompareTag("Player"))
            inside = true;
    }

    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.CompareTag("Player"))
            inside = false;
    }

    void SecondFloor()
    {
        // Coordenadas do World Space
        teleporter.transform.position = new Vector3(0, 7, 2);
    }

    void FirstFloor()
    {
        // Coordenadas do World Space
        teleporter.transform.position = new Vector3(0, 0, 0);
    }

    void Garage()
    {
        // Coordenadas do World Space
        teleporter.transform.position = new Vector3(0, 0, 0);
    }
}