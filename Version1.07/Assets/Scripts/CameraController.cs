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
		
		if (left && !ToFarLeft())
		{
			Vector3 position = transform.position;
			position.x = transform.position.x + (float)(0.1*(Math.Sin(transform.rotation.y)-1));
			position.z = transform.position.z + (float)(0.1*(Math.Cos(transform.rotation.y)-1));
			transform.position = position;
		}
		if (right && !ToFarRight())
		{
			Vector3 position = transform.position;
			position.x = transform.position.x - (float)(0.1*(Math.Sin(transform.rotation.y)-1));
			position.z = transform.position.z - (float)(0.1*(Math.Cos(transform.rotation.y)-1));
			transform.position = position;
		}
		if (up && !ToFarUp())
		{
			Vector3 position = transform.position;
			position.x = transform.position.x - (float)(0.1*(Math.Cos(transform.rotation.y)-1));
			position.z = transform.position.z - (float)(0.1*(Math.Sin(transform.rotation.y)-1));
			transform.position = position;
		}
		if (down && !ToFarDown())
		{
			Vector3 position = transform.position;
			position.x = transform.position.x + (float)(0.1*(Math.Cos(transform.rotation.y)-1));
			position.z = transform.position.z + (float)(0.1*(Math.Sin(transform.rotation.y)-1));
			transform.position = position;
		}
	}
	
	bool ToFarLeft()
	{
		if ((int)Math.Cos(transform.rotation.y) == 1 && transform.position.x <= -22.5)
		{
			return true;
		}
		if ((int)Math.Cos(transform.rotation.y) == -1 && transform.position.x >= 22.5)
		{
			return true;
		}
		if ((int)Math.Sin(transform.rotation.y) == 1 && transform.position.z >= 22.5)
		{
			return true;
		}
		if ((int)Math.Sin(transform.rotation.y) == -1 && transform.position.z <= -22.5)
		{
			return true;
		}
		return false;
	}
	
	bool ToFarRight()
	{
		if ((int)Math.Cos(transform.rotation.y) == 1 && transform.position.x >= 22.5)
		{
			return true;
		}
		if ((int)Math.Cos(transform.rotation.y) == -1 && transform.position.x <= -22.5)
		{
			return true;
		}
		if ((int)Math.Sin(transform.rotation.y) == 1 && transform.position.z <= -22.5)
		{
			return true;
		}
		if ((int)Math.Sin(transform.rotation.y) == -1 && transform.position.z >= 22.5)
		{
			return true;
		}
		return false;
	}
	
	bool ToFarUp()
	{
		if ((int)Math.Cos(transform.rotation.y) == 1 && transform.position.z >= 22.5)
		{
			return true;
		}
		if ((int)Math.Cos(transform.rotation.y) == -1 && transform.position.z <= -22.5)
		{
			return true;
		}
		if ((int)Math.Sin(transform.rotation.y) == 1 && transform.position.x >= 22.5)
		{
			return true;
		}
		if ((int)Math.Sin(transform.rotation.y) == -1 && transform.position.x <= -22.5)
		{
			return true;
		}
		return false;
	}
	
	bool ToFarDown()
	{
		if ((int)Math.Cos(transform.rotation.y) == 1 && transform.position.z <= -22.5)
		{
			return true;
		}
		if ((int)Math.Cos(transform.rotation.y) == -1 && transform.position.z >= 22.5)
		{
			return true;
		}
		if ((int)Math.Sin(transform.rotation.y) == 1 && transform.position.x <= -22.5)
		{
			return true;
		}
		if ((int)Math.Sin(transform.rotation.y) == -1 && transform.position.x >= 22.5)
		{
			return true;
		}
		return false;
	}
}
