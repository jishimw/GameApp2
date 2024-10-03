using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public static DoorManager instance;
    private int keysCollected = 0;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void AddKey()
    {
        keysCollected++;
    }

    public int GetKeyCount()
    {
        return keysCollected;
    }

    public void ResetKeys()
    {
        keysCollected = 0;
    }

    public bool CanOpenDoor()
    {
        if(keysCollected > 0)
        {
            return true;
        }
        return false;
    }
}