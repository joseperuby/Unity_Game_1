using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public int messiScore = 0, ronaldoScore = 0;
    public float timer = 30f;
    public TextMeshProUGUI scoreText;
    public string score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            Debug.Log("Game Over");
        }
        score = messiScore.ToString() + " - " + ronaldoScore.ToString();
        scoreText.text = score.ToString();
    }
}
