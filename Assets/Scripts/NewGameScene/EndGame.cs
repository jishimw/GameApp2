using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{
    public Timer timer;
    private float time;
    //public Leaderboard leaderboard;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            time = timer.GetTime(); //get the time
            timer.Finish();         //stop the timer
            //stop the game from running
            //Time.timeScale = 0;
            PlayerPrefs.SetFloat("PlayerTime", time);   //save the time to player prefs
            Debug.Log("Game Over! Time: " + time);

            //Load the NameInput scene
            SceneManager.LoadScene("NameInput");
        }
    }
}
