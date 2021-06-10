using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupFruit : InteractBehaviour
{
    public delegate void FruitPickedUp(string name);
    public event FruitPickedUp Picked;

    public string itemName;
    public override void OnInteract()
    {
        Picked?.Invoke(itemName);
        gameObject.SetActive(false);
        Debug.Log("Picked up " + itemName);
    }

}
