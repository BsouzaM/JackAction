using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static Enums;

public class MouseLook : MonoBehaviour
{
    [Range(0.2f, 5f)]
    public float Maxdist = 0.9f;
    private Controls _Controls;
    /// <summary>
    /// Sensibilidade do rato
    /// </summary>
    [Range(0.2f, 300f)]
    public float Sensibilidade = 15;
    public float UpperAngle
    {
        get
        {
            return _UpperAngle;
        }
        set
        {
            UpperAngleInRad = value * Mathf.PI / 180;
            _UpperAngle = value;
        }
    }
    /// <summary>
    /// Maximo de angulo para cima
    /// </summary>
    [SerializeField]
    private float _UpperAngle = 40;
    private float UpperAngleInRad;
    public float LowerAngle
    {
        get
        {
            return _LowerAngle;
        }
        set
        {
            LowerAngleInRad = value * Mathf.PI / 180;
            _LowerAngle = value;
        }
    }
    /// <summary>
    /// Maximo de angulo para baixo
    /// </summary>
    [SerializeField]
    private float _LowerAngle = 30;
    private float LowerAngleInRad;

    public List<Transform> cornerpos;

    public LookState CameraState;

    private Vector2 dir;
    private bool mouse;


    // Start is called before the first frame update
    void Start()
    {
        cornerpos.RemoveAt(0);
        FindObjectOfType<PlayerMovement>().Entered += MouseLook_Entered;
        FindObjectOfType<PlayerMovement>().Exit += MouseLook_Exit;
        UpperAngle = _UpperAngle;
        LowerAngle = _LowerAngle;
        Cursor.lockState = CursorLockMode.Locked;
        CameraState = LookState.THIRDPERSON;
    }

    private void MouseLook_Exit(Collider other)
    {
        if (other.transform.tag == "RoomSection")
        {
            cornerpos.Remove(other.transform);
            if (cornerpos.Count == 0)
            {
                CameraState = LookState.THIRDPERSON;
                transform.LookAt(transform.parent);
            }
        }
    }

    private void MouseLook_Entered(Collider other)
    {
        if (other.transform.tag == "RoomSection")
        {
            CameraState = LookState.CORNERVIEW;
            cornerpos.Add(other.transform);
        }
    }

    private void OnEnable()
    {
        _Controls = new Controls();
        _Controls.Player.MouseMovement.performed += HandleLook;
        _Controls.Player.MouseMovement.canceled += MouseMovement_canceled;
        _Controls.Player.ChangeSensibility.performed += ChangeSensibility_performed;
        _Controls.Player.ChangeSensibility.Enable();
        _Controls.Player.MouseMovement.Enable();
    }

    private void ChangeSensibility_performed(InputAction.CallbackContext obj)
    {
        Sensibilidade += obj.ReadValue<float>()*5f;
    }

    private void MouseMovement_canceled(InputAction.CallbackContext obj)
    {
        dir = Vector2.zero;
    }

    private void HandleLook(InputAction.CallbackContext obj)
    {
        dir = obj.ReadValue<Vector2>();
        mouse = obj.control.device.name == "Mouse";
    }

    private void OnDisable()
    {
        _Controls.Player.MouseMovement.performed -= HandleLook;
        _Controls.Player.MouseMovement.Disable();
        _Controls.Player.ChangeSensibility.performed -= ChangeSensibility_performed;
        _Controls.Player.MouseMovement.canceled -= MouseMovement_canceled;
        _Controls.Player.ChangeSensibility.Disable();
    }



    void MoveCam(Vector2 read)
    {
        if (CameraState == LookState.THIRDPERSON)
        {
            if ((transform.eulerAngles.x + read.y < LowerAngle && transform.eulerAngles.x < 180) ||
                (transform.eulerAngles.x + read.y > 360 - UpperAngle && transform.eulerAngles.x > 180)
               )
            {
                transform.Rotate(new Vector3(read.y, 0, 0));
            }
            //transform.parent.Rotate(new Vector3(0f, read.x, 0f));
            transform.RotateAround(Vector3.zero, Vector3.up, read.x);
        }
    }
    private void Update()
    {
        MoveCam(dir / 100 * Sensibilidade);
        if (mouse)
            dir = Vector2.zero;

        RaycastHit hit;
        switch (CameraState)
        {
            case LookState.THIRDPERSON:

                if (Physics.Raycast(transform.parent.position, -transform.forward, out hit, Maxdist))
                {
                    transform.position = transform.parent.position - (transform.forward * hit.distance);
                }
                else
                {
                    transform.position = transform.parent.position - (transform.forward * Maxdist);
                }
                break;
            case LookState.CORNERVIEW:
                if (cornerpos.Count > 0)
                {
                    transform.position = cornerpos[0].GetChild(0).position;
                    transform.LookAt(transform.parent);
                }
                else
                {
                    if (Physics.Raycast(transform.parent.position, -transform.forward, out hit, Maxdist))
                    {
                        transform.position = transform.parent.position - (transform.forward * hit.distance);
                    }
                    else
                    {
                        transform.position = transform.parent.position - (transform.forward * Maxdist);
                    }
                }
                break;
            default:
                CameraState = LookState.THIRDPERSON;
                break;
        }

    }

}
