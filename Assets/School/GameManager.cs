using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject ballPrefab;
    [SerializeField] private int life;
    private int _score;
    private float leftTime;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text textGameOver;
    [SerializeField] private Text textlife;
    [SerializeField] private Text textTimer;
    private bool inGame = true;
    private void Start()
    {
        leftTime = 10f;
        life = 10;
        textGameOver.enabled = false;
        textlife.text = life.ToString();
        
    }
    void Update()
    {
        if (inGame)
        {
            leftTime -= Time.deltaTime;
            textTimer.text = "Time:" + (leftTime > 0f ? leftTime.ToString("0.00") : "0.00");
            if (leftTime < 0f)
            {
                textGameOver.enabled = true;
                inGame = false;
            }
        }
        GameObject ball = GameObject.Find("Ball");
        if(ball == null)
        {
            --life;
            textlife.text = life.ToString();
            if(life > 0)
            {
                GameObject newBall = Instantiate(ballPrefab);
                newBall.name = ballPrefab.name;
            }
            else
            {
                life = 0;
                textlife.text = life.ToString();
                textGameOver.enabled = true;
            }
        }

    }

    public void AddScore(int score)
    {
        _score += score;
        scoreText.text = _score.ToString();

    }
}
