using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) //THIS FUNCTION IS NOT RUNNING FOR SOME REASON
    {
        //Check if player has collided with door and the key to open it
        if (other.CompareTag("Player") && DoorManager.instance.CanOpenDoor())
        {
            // Open door by rotating its inner part 90 degrees
            transform.GetChild(0).Rotate(0, 0, -90);

            // Reset key count
            DoorManager.instance.ResetKeys();
        }
    }
}