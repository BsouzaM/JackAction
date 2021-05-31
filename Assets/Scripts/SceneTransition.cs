using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    private Controls _Controls;
    private bool casa = true;

    private void OnEnable()
    {
        _Controls = new Controls();
        _Controls.Player.ChangeScene.performed += ChangeScene_performed;
        _Controls.Player.ChangeScene.Enable();
    }

    private void OnDisable()
    {
        _Controls = new Controls();
        _Controls.Player.ChangeScene.performed -= ChangeScene_performed;
        _Controls.Player.ChangeScene.Disable();
    }

    private void ChangeScene_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        if (casa)
        {
            casa = false;
            SceneManager.LoadScene("JA_Supermarket_Interior");
            
        }
        else
        {

            SceneManager.LoadScene("JA_House_Interior");
            
        }

    }

}
