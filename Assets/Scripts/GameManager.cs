using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public int score;
	public int lives;
	public Text LivesText;
	public Text ScoreText;
	public bool gameOver;
	public GameObject gameOverPanel;
	
    void Start()
    {
        LivesText.text = "Lives: " + lives;
		ScoreText.text = " " + score;
    }

    public void UpdateLives(int changeInLives)
    {
		lives += changeInLives;
		if (lives <= 0)
		{
			lives = 0;
			GameOver();
		}
		LivesText.text = "Lives: " + lives;
    }
	
	public void UpdateScore(int changePoints)
	{
		score += changePoints;
		
		ScoreText.text = " " + score;
	}
	
	void GameOver()
	{
		gameOver = true;
		gameOverPanel.SetActive (true);
	}
	
	public void PlayAgain()
	{
		SceneManager.LoadScene("SampleScene");
	}
	
	public void Quit()
	{
		SceneManager.LoadScene("MenuScene");
	}
}
