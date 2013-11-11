using UnityEngine;
using System.Collections;

public class SpawnScriptTest : MonoBehaviour {

	bool active = true;
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
	}
}
