using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStats : MonoBehaviour
{
    public static int curedCells = 0;
    public static int virusCells = 0;
    public static float overallTimeRemaining = 32f;

    public CanvasGroup EndGamePanel;
    public Text timeRemainingText, cureScore, virusScore;

    void Update()
    {
        overallTimeRemaining -= Time.deltaTime;
        timeRemainingText.text = ((int)overallTimeRemaining).ToString();

        if ((int)overallTimeRemaining <= 0)
        {
            cureScore.text = curedCells.ToString();
            virusScore.text = virusCells.ToString();
            EndGamePanel.interactable = true;
            EndGamePanel.alpha = 1;

            Time.timeScale = 0;
        }
    }

    public void PlayAgain()
    {
        curedCells = 0;
        virusCells = 0;
        overallTimeRemaining = 32f;
        Time.timeScale = 1;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
