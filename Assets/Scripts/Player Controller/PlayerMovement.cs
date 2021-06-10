﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static Enums;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    /// <summary>
    /// Jogador principal, isto e um singleton
    /// </summary>
    public static PlayerMovement current;
    private Vector2 _moveaxis;
    /// <summary>
    /// Movimento a ser produzido pelo jogador
    /// </summary>
    public Vector2 MoveAxis => _moveaxis;
    /// <summary>
    /// Script Compilado em C# do novo input system do unity, o antigo e default nao ria funcionar
    /// </summary>
    private Controls _Controls;
    /// <summary>
    /// RigidBody do jogador
    /// </summary>
    private Rigidbody _player_rb;
    public Rigidbody Player_Rb => _player_rb;
    /// <summary>
    /// Estado atual do jogador
    /// </summary>
    private PlayerState currentState;
    /// <summary>
    /// Velocidade do jogador
    /// </summary>
    [Range(2f, 10f)]
    public float moveSpeed = 7f;
    public Camera correctCamera;
    public delegate void TriggerEnter(Collider other);
    public event TriggerEnter Entered;
    public event TriggerEnter Exit;

    public Quaternion rot;
    private void OnEnable()
    {
        _Controls = new Controls();
        _Controls.Player.DirectionalMovement.performed += HandleMove;
        _Controls.Player.DirectionalMovement.Enable();
    }

    private void HandleMove(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        try
        {
            _moveaxis = context.ReadValue<Vector2>();

            if (MoveAxis == Vector2.zero)
            {
                currentState = PlayerState.STILL;
            }
            else
            {
                rot = Quaternion.Euler(Vector3.Scale(Vector3.up, Camera.main.transform.rotation.eulerAngles));
                Camera.main.transform.localEulerAngles = new Vector3(Camera.main.transform.eulerAngles.x, 0, Camera.main.transform.eulerAngles.z);
                currentState = PlayerState.MOVING;
            }
        }
        catch
        {
            throw new System.NotImplementedException();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Entered?.Invoke(other);
    }
    private void OnTriggerExit(Collider other)
    {
        Exit?.Invoke(other);
    }

    private void OnDisable()
    {
        _Controls.Player.DirectionalMovement.performed -= HandleMove;
        _Controls.Player.DirectionalMovement.Disable();
    }

    private void Awake()
    {
        if (current == null)
            current = this;
        else
            Destroy(this);
    }

    private void Start()
    {
        _player_rb = GetComponent<Rigidbody>();
        Player_Rb.freezeRotation = true;
        correctCamera = Camera.main;
    }


    private void Update()
    {
        switch (currentState)
        {
            case PlayerState.STILL:
                break;
            case PlayerState.MOVING:
                MovePlayer();
                break;
            default:
                Debug.LogError("NO STATE");
                break;
        }
    }

    private void MovePlayer()
    {
        if (correctCamera.gameObject.activeSelf)
        {
            Vector3 res = new Vector3(MoveAxis.x * moveSpeed, 0, MoveAxis.y * moveSpeed);
            transform.rotation = rot;
            res = transform.rotation * res;
            //Player_Rb.AddRelativeForce(res, ForceMode.VelocityChange);
            transform.position += res * Time.deltaTime;


            rot = Quaternion.Lerp(rot, Quaternion.Euler(Vector3.Scale(Vector3.up, Camera.main.transform.rotation.eulerAngles)), 0.8f);
            Camera.main.transform.localEulerAngles = new Vector3(Camera.main.transform.eulerAngles.x, 0, Camera.main.transform.eulerAngles.z);

        }
    }
}
