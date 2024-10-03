//Leaderboard.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Leaderboard : MonoBehaviour
{
    public Text Name;
    public Text Time;

    public Button MainMenuButton;
    public Button NewGameButton;

    void Start()
    {
        //Clear the Texts
        Name.text = "";
        Time.text = "";

        //Load the stats data
        LoadStats(); 
    }

    void LoadStats() //NOT LOADPLAYERPREFS LIKE IT SHOULD!!!!!!!
    {
        // Get the current player count
        int playerCount = PlayerPrefs.GetInt("PlayerCount", 0);

        // Create a list to hold the players' data
        List<KeyValuePair<string, float>> leaderboard = new List<KeyValuePair<string, float>>();

        // Load all saved player names and times
        for (int i = 0; i < playerCount; i++) {
            string playerName = PlayerPrefs.GetString("PlayerName" + i, "N/A");
            float playerTime = PlayerPrefs.GetFloat("PlayerTime" + i, 0f);

            // Add to the leaderboard list
            leaderboard.Add(new KeyValuePair<string, float>(playerName, playerTime));
        }

        // Sort the leaderboard by time (ascending order - shortest time first)
        leaderboard.Sort((x, y) => x.Value.CompareTo(y.Value));

        // Display the top 5 players
        for (int i = 0; i < Mathf.Min(5, leaderboard.Count); i++) {
            if(leaderboard[i].Key == "") {
                Name.text += "N/A\n\n\n";
            } else if(leaderboard[i].Value == 0) {
                Time.text += "0.00\n\n\n";
            } else {
                Name.text += leaderboard[i].Key + "\n\n\n";
                Time.text += leaderboard[i].Value.ToString("F2") + "\n\n\n";
            }
        }


        //Display the time and name of the player top 5 players using PlayerPrefs
        /*for (int i = 0; i < 5; i++)
        {
            if (PlayerPrefs.HasKey("PlayerTime"))
            {
                Time.text += PlayerPrefs.GetFloat("PlayerTime").ToString("F2") + "\n";
            }
            else
            {
                Time.text += "0.00\n\n";
            }

            if (PlayerPrefs.HasKey("PlayerName"))
            {
                Name.text += PlayerPrefs.GetString("PlayerName") + "\n";
            }
            else
            {
                Name.text += "N/A\n\n";
            }
        }*/
        
    }

    public void MainMenu()
    {
        //Load the MainMenu scene
        SceneManager.LoadScene("Main Menu");
    }

    public void NewGame()
    {
        //Load the NewGame scene
        SceneManager.LoadScene("NewGameScene");
    }
}