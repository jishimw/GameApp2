using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class MainMenu : MonoBehaviour
{
    public string newGameScene;
    public string leaderBoard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame(){
        SceneManager.LoadScene(newGameScene);
    }

    public void LeaderBoard(){      //DON'T FORGET TO CREATE YOUR LEADERBOAD PAGE..?
        SceneManager.LoadScene(leaderBoard);
    }

    public void Quit(){
        Application.Quit();
    }
}
