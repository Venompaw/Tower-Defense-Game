using UnityEngine;
using System.Collections;

public class SpawnScriptTest : MonoBehaviour {

	bool active = true;
	bool testStop = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetMouseButtonDown(0)) 
        {
			active = false;
			this.SendMessage("PlaceTower", active);
		}
		if (Input.GetKeyDown(KeyCode.H))
		{
			testStop = !testStop;
			this.SendMessage("TestStop", testStop);
		}
	}
}
