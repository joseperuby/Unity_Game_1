using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int messiScore = 0, ronaldoScore = 0;
    public float timeRemaining = 60f;
    public TextMeshProUGUI timer;
    public TextMeshProUGUI scoreText;
    public string score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTime(timeRemaining);
        }
        else if (timeRemaining <= 0f)
        {
            SceneManager.LoadSceneAsync(2);
        }
        score = messiScore.ToString() + " - " + ronaldoScore.ToString();
        scoreText.text = score.ToString();
    }

    public void UpdateTime(float timeLeft)
    {
        timer.text = "Time remaining: " + timeLeft;
    }
}
