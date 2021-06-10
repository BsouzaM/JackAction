using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]
public abstract class InteractBehaviour : MonoBehaviour
{
    public delegate void Success(bool result);

    public abstract void OnInteract();

    
}
