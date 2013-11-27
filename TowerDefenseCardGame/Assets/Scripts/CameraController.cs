using UnityEngine;
using System.Collections;
using System;

public class CameraController : MonoBehaviour 
{
	private bool left;
	private bool right;
	private bool up;
	private bool down;

	// Use this for initialization
	void Start () 
	{
		left = false;
		right = false;
		up = false;
		down = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
		{
			left = true;
		}
		if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
		{
			left = false;
		}
		
		if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
		{
			right = true;
		}
		if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
		{
			right = false;
		}
		
		if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
		{
			up = true;
		}
		if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W))
		{
			up = false;
		}
		if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
		{
			down = true;
		}
		if(Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
		{
			down = false;
		}
		
		if (left && transform.position.x >= -42)
		{
			Vector3 position = transform.position;
			position.x = transform.position.x - 0.1f;
			transform.position = position;
		}
		if (right && transform.position.x <= 42)
		{
			Vector3 position = transform.position;
			position.x = transform.position.x + 0.1f;
			transform.position = position;
		}
		if (up && transform.position.z <= 42)
		{
			Vector3 position = transform.position;
			position.z = transform.position.z + 0.1f;
			transform.position = position;
		}
		if (down && transform.position.z >= -42)
		{
			Vector3 position = transform.position;
			position.z = transform.position.z - 0.1f;
			transform.position = position;
		}
	}
}
