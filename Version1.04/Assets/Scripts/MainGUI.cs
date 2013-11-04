using UnityEngine;
using System.Collections;

public class MainGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnGUI() {
        if (GUI.Button(new Rect(10, 10, 150, 100), "Start Round"))
		{
            BroadcastMessage("StartRound");
		}
    }
	// Update is called once per frame
	void Update () {
	
	}
}
