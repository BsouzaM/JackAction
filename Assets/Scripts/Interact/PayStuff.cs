using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PayStuff : InteractBehaviour
{
    private Controls _Controls;
    public GameObject CutsceneScreen;
    public List<string> Items = new List<string>();
    public override void OnInteract()
    {
        if (Items.Count > 1)
        {
            _Controls.Player.Skip.Enable();
            CutsceneScreen.SetActive(true);
        }
    }

    private void Start()
    {
        foreach(PickupFruit este in FindObjectsOfType<PickupFruit>())
        {
            este.Picked += Este_Picked;
        }
    }

    private void Este_Picked(string name)
    {
        Items.Add(name);
    }
    private void OnEnable()
    {
        _Controls = new Controls();
        _Controls.Player.Skip.performed += Skip_performed;
    }
    private void OnDisable()
    {
        _Controls.Player.Skip.performed -= Skip_performed;
        _Controls.Player.Skip.Disable();
    }

    private void Skip_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        SceneManager.LoadScene("JA_House_Interior");
    }
}
