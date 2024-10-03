using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;  // Reference to the UI Text component
    private float startTime;
    private bool isFinished = false;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (isFinished) return;

        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;  // Update the text
    }

    public float GetTime()
    {
        return Time.time - startTime;
    }

    public void Finish()
    {
        isFinished = true;
    }
}
