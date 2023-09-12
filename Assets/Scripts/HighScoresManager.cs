using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HighScoresManager : MonoBehaviour
{
    public TextMeshProUGUI highScoresText;

    public void Start()
    {
        int score;
        string player;
        highScoresText.text = "";
        for(int i = 1; i < 11; i++)
        {
            score = PlayerPrefs.GetInt("HighScore" + i, 0);
            player = PlayerPrefs.GetString("HighScorePlayerName" + i, "");
            if (i != 10)
            {
                highScoresText.text += i.ToString() + ".  " + player + " : " + score.ToString() + "<br>";
            }
            else
            {
                highScoresText.text += i.ToString() + "." + player + " : " + score.ToString();
            }
        }
    }

    public void ResetHighScores()
    {
        for (int i = 1; i < 11; i++)
        {
            PlayerPrefs.SetInt("HighScore" + i, 0);
            PlayerPrefs.SetString("HighScorePlayerName" + i, "");
        }
        Start();
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
