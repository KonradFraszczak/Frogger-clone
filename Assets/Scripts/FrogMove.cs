using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[DisallowMultipleComponent]
public class FrogMove : MonoBehaviour
{
	[SerializeField]Transform target;
	[SerializeField]Direction dir;
	
	void OnMouseDown()
	{
		Vector3 pos = target.position;
		
		switch(dir)
		{
			case Direction.Down:
			pos += Vector3.down;
			break;
			case Direction.Up:
			pos += Vector3.up;
			break;
			case Direction.Right:
			pos += Vector3.right;
			break;
			case Direction.Left:
			pos += Vector3.left;
			break;
			default:
			pos = Vector3.zero;
			break;
		}
		
		target.position = pos;
	}
}

public enum Direction
{
	Up,
	Down,
	Left,
	Right
}

