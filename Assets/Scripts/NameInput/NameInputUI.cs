//NameInputUI.cs
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameInputUI : MonoBehaviour
{
    public GameObject nameInputUI;
    public Text TimeText;
    public InputField nameInput;

    // Start is called before the first frame update
    void Start()
    {
        //Show the name input UI
        nameInputUI.SetActive(true);

        //Load the player's score
        float time = PlayerPrefs.GetFloat("PlayerTime");
        TimeText.text = "Your Time: " + time.ToString("f2");
    }

    public void SaveName() {
        //Only allow for non-empty 3 character names in the input field
        if (nameInput.text.Length != 3) {
            Debug.Log("Name must be 3 characters long!");
            return;
        } else {
            Debug.Log("Name: " + nameInput.text);
        }
        
        // Get the current number of saved scores (track the number of players)
        int playerCount = PlayerPrefs.GetInt("PlayerCount", 0);

        // Save the player's name and time under unique keys
        PlayerPrefs.SetString("PlayerName" + playerCount, nameInput.text);
        PlayerPrefs.SetFloat("PlayerTime" + playerCount, PlayerPrefs.GetFloat("PlayerTime"));

        // Increment and save the player count for next time
        PlayerPrefs.SetInt("PlayerCount", playerCount + 1);

        // Load the next scene (Leaderboard)
        SceneManager.LoadScene("Leaderboard");
    }
}
