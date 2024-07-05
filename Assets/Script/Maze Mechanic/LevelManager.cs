using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [Header("Retry Scene Setting")]
    public string retryScene;

    [Header("Timer Setting")]
    public TextMeshProUGUI timerText;
    public float timer;

    [Header("Gameover Panel")]
    public GameObject gameoverPanel;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        TimerGame();
    }

    public void TimerGame()
    {
        timer += Time.deltaTime;

        // Convert the timer to a time format (minutes:seconds)
        int minutes = Mathf.FloorToInt(timer / 60F);
        int seconds = Mathf.FloorToInt(timer % 60F);

        // Update the TextMeshProUGUI text with the formatted time
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        // Example condition: Game over if the timer reaches 60 seconds
        if (minutes >= 1)
        {
            GameOver();
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(retryScene);
        
        gameoverPanel.SetActive(false);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameoverPanel.SetActive(true);
    }

    public void BackToMainmenu()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
