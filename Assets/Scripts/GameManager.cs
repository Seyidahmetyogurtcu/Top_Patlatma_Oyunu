using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winText;
    public GameObject restartButton;
    int score = 0;

    public void ScoreUp()
    {
        score++;
        if (score>=8)
        {
            win();
        }
    }
    private void win()
    {
        winText.SetActive(true);
        restartButton.SetActive(true);
    }
    public  void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}