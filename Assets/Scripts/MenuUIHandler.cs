using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public string player;
    public TextMeshProUGUI bestScore;
    public TextMeshProUGUI placeHolder;

    public void Awake()
    {
        bestScore.text = "Best Score: " + PlayerPrefs.GetString("HighScorePlayerName1", "") + " : " + PlayerPrefs.GetInt("HighScore1", 0).ToString();
        string currentPlayer = PlayerPrefs.GetString("CurrentPlayerName", "");
        if(currentPlayer != "")
        {
            placeHolder.text = currentPlayer;
        }
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        PlayerPrefs.SetString("CurrentPlayerName", "");
        UnityEditor.EditorApplication.ExitPlaymode();
#else
        PlayerPrefs.SetString("CurrentPlayerName", "");
        Application.Quit();
#endif
    }

    public void NameOfPlayer(string playerName)
    {
        player = playerName;
        PlayerPrefs.SetString("CurrentPlayerName", player);
    }

    public void HighScores()
    {
        SceneManager.LoadScene(2);
    }
}
