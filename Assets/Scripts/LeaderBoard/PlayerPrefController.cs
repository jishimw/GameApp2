//PlayerPrefController.cs
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

//https://docs.unity3d.com/ScriptReference/PlayerPrefs.html
public class PlayerPrefController : MonoBehaviour
{ 
    //public TMP_InputField inputField;

    public void SavePlayerPrefs(string nameChars, float time)
    {
        //Save the inputfield's text under the key 'stringpref'
        PlayerPrefs.SetString("PlayerName", nameChars/*inputField.text*/);
        PlayerPrefs.SetFloat("PlayerTime", time);
    }

    public void LoadPlayerPrefs()
    {
        //Then load it by providing the same key
        string nameChars = PlayerPrefs.GetString("PlayerName");
        float time = PlayerPrefs.GetFloat("PlayerTime");
        Debug.Log("Player Name: " + nameChars + " Time: " + time);
        //Debug.Log(PlayerPrefs.GetString("stringpref"));
    }
    void ClearPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}
