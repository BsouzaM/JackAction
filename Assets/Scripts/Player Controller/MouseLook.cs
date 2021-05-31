using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    [Range(0.2f, 5f)]
    public float Maxdist = 0.9f;
    private Controls _Controls;
    /// <summary>
    /// Sensibilidade do rato
    /// </summary>
    [Range(0.2f, 10f)]
    public float Sensibilidade = 1;
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



    // Start is called before the first frame update
    void Start()
    {
        UpperAngle = _UpperAngle;
        LowerAngle = _LowerAngle;
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void OnEnable()
    {
        _Controls = new Controls();
        _Controls.Player.MouseMovement.performed += HandleLook;
        _Controls.Player.MouseMovement.Enable();
    }

    private void HandleLook(InputAction.CallbackContext obj)
    {
        if (obj.ReadValue<Vector2>().magnitude > 0)
        {
            MoveCam(obj.ReadValue<Vector2>() / 100 * Sensibilidade);
        }
        else
        {
            Debug.Log("no input");
        }
    }

    private void OnDisable()
    {
        _Controls.Player.MouseMovement.performed -= HandleLook;
        _Controls.Player.MouseMovement.Disable();
    }



    void MoveCam(Vector2 read)
    {


        if ((transform.eulerAngles.x + read.y < LowerAngle && transform.eulerAngles.x < 180) ||
            (transform.eulerAngles.x + read.y > 360 - UpperAngle && transform.eulerAngles.x > 180)
           //transform.rotation.x >= -UpperAngleInRad &&
           //transform.rotation.x <= LowerAngleInRad
           )
        {
            transform.Rotate(new Vector3(read.y, 0, 0));
        }
        //else
        //{
        //    if (transform.rotation.x + read.y > LowerAngleInRad)
        //    {
        //        Debug.Log("Snapping to lower");
        //        transform.eulerAngles = new Vector3(LowerAngle, 0f, 0f);
        //    }
        //    else
        //    {
        //        Debug.Log("Snapping to higher");
        //        transform.eulerAngles = new Vector3(360 - UpperAngle, 0f, 0f);
        //    }
        //}
        transform.parent.Rotate(new Vector3(0f, read.x, 0f));
    }

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.parent.position, -transform.forward, out hit, Maxdist))
        {
            transform.position = transform.parent.position - (transform.forward * hit.distance);
        }
        else
        {
            transform.position = transform.parent.position - (transform.forward * Maxdist);
        }
    }

}
