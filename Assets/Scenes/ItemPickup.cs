using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item itemtest;


    public void Pickup()
    {
        Inventory.Instance.Add(itemtest);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        print("pickup Trigger");
        Pickup();
    }
}
