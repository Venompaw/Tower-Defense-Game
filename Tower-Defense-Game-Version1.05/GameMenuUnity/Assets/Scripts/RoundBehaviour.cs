using UnityEngine;
using System.Collections;

public class RoundBehaviour : MonoBehaviour {
	
	private int round;
	// Use this for initialization
	void Start () {
	guiText.text = round.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	guiText.text = round.ToString();
	}
}
