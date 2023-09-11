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

    public void Awake()
    {
        bestScore.text = "Best Score: " + PlayerPrefs.GetString("HighScorePlayerName", "") + " : " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void NameOfPlayer(string playerName)
    {
        player = playerName;
        PlayerPrefs.SetString("PlayerName", player);
    }

    public void HighScores()
    {

    }
}
