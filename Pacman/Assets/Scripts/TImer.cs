using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TImer : MonoBehaviour
{
    public Text timerText;
    public float timeLimit = 60f;

    private float currentTime;

    void Start()
    {
        currentTime = timeLimit;
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            UpdateTimerText();

            if (currentTime <= 0)
            {
                SceneManager.LoadScene("GameOver");
                print("Time's up!");
            }
        }
    }

    void UpdateTimerText()
    {
        timerText.text = "Time: " + Mathf.Round(currentTime).ToString();
    }
}

