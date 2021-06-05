using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractActor : MonoBehaviour
{
    public List<Collider> inside = new List<Collider>();
    private Controls _Controls;

    private void OnEnable()
    {
        _Controls = new Controls();
        _Controls.Player.Interact.performed += Interact_performed;
        _Controls.Player.Interact.Enable();
    }

    private void OnDisable()
    {
        _Controls.Player.Interact.performed -= Interact_performed;
        _Controls.Player.Interact.Disable();
    }

    private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        foreach (Collider este in inside)
        {
            if (este.GetComponent<InteractBehaviour>())
            {
                este.GetComponent<InteractBehaviour>().OnInteract();
                break;
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        inside.Add(other);
    }

    private void OnTriggerExit(Collider other)
    {
        inside.Remove(other);
    }
}
