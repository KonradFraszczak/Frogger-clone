using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{
	public Rigidbody2D rb;
	public GameManager GM;
	public Transform RespawnPosition;

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.CompareTag ("Car"))
		{
			Debug.Log ("FAIL");
			ScoreScript.CurrentScore = 0;
			Respawn();
			GM.UpdateLives (-1);
		}
		
		if (col.CompareTag ("Goal"))
		{
			GM.UpdateScore (+100);
		}
	}
	
	
	public void Respawn()
	{
		transform.position = RespawnPosition.position;
	}
}
