using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStats : MonoBehaviour {

    public static int curedCells = 0;
    public static int virusCells = 0;
    public static float overallTimeRemaining = 45f;

    public Text timeRemainingText;

    void Update()
    {
        overallTimeRemaining -= Time.deltaTime;
        timeRemainingText.text = ((int)overallTimeRemaining).ToString();
    }

}
