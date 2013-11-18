using UnityEngine;
using System.Collections;

public class ErrorController : MonoBehaviour {
	public float duration = 0.2f;
	private float startTime;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if ((Time.time - startTime) >= duration)
		{
			guiText.text="";
		}
	}
	
	void DisplayMessage (string message)
	{
		guiText.text= message;
		startTime = Time.time;
	}
}
