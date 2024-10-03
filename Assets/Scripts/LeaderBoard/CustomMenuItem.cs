using UnityEngine;
using UnityEditor;

public class CustomMenuItem : Editor
{
    //MenuItem will define a new menu item in the Unity Editor Tool bar
    [MenuItem("Tools/Clear PlayerPrefs")]
    private static void NewMenuOption()
    {
        //We can then set what happens when we select that menu item
        //In our case we will clear all Player Prefs
        PlayerPrefs.DeleteAll();
        Debug.Log("Player Prefs cleared.");
    }
}
