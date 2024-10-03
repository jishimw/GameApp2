using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Logic to pick up key
            DoorManager.instance.AddKey();
            Destroy(gameObject);

        }
    }
}
