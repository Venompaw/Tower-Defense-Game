using UnityEngine;
using System.Collections;

public class StartRoundGUI : MonoBehaviour {
	
	public int round;
	public GUIText roundDisplay;
	private bool roundStarted;
	// Use this for initialization
	void Start () {
	roundDisplay.text="Round: " + round.ToString();
	}
	void OnGUI() {
        if (GUI.Button(new Rect(10, 10, 150, 100), "Start Round"))
		{
			BroadcastMessage("StartRound");  
			roundDisplay.text="Round: " + round.ToString();
			
			
		}
		
    }
	
	void SetRoundCount(int i)
	{
		round = i;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
