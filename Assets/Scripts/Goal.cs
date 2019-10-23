using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{

	void OnTriggerEnter2D (Collider2D other)
	{
		
		Debug.Log ("WON");
		ScoreScript.CurrentScore += 100;
		other.GetComponent<Frog>().Respawn();
		ScoreScript.CurrentScore += 100;
		
	}
	
}
