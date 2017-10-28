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
    public static bool singlePlayerMode = false;

    public CanvasGroup EndGamePanel, TutorialPanel, InGamePanel;
    public Text timeRemainingText, cureScore, virusScore;

    void Start()
    {
        EndGamePanel.interactable = false;
        EndGamePanel.alpha = 0;
        EndGamePanel.blocksRaycasts = false;

        TutorialPanel.interactable = true;
        TutorialPanel.alpha = 1;
        TutorialPanel.blocksRaycasts = true;

        InGamePanel.alpha = 0;

        Time.timeScale = 0;
    }

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
            EndGamePanel.blocksRaycasts = true;

            Time.timeScale = 0;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            Application.Quit();
        }
    }

    public void PlayAgain()
    {
        curedCells = 0;
        virusCells = 0;
        overallTimeRemaining = 32f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PlayGame(bool singlePlayer)
    {
        singlePlayerMode = singlePlayer;
        Debug.Log(singlePlayerMode);

        TutorialPanel.interactable = false;
        TutorialPanel.alpha = 0;
        TutorialPanel.blocksRaycasts = false;

        InGamePanel.alpha = 1;

        Time.timeScale = 1;
    }

}
