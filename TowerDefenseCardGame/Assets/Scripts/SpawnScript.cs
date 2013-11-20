using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	bool active;
	bool placementStop;
	
	// Use this for initialization
	void Start () {
	active = true;
		placementStop = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetMouseButtonDown(0)) 
        {
			active = false;
			this.SendMessage("PlaceTower", active);
		}
		if (Input.GetKeyDown(KeyCode.H))//Add statements for different tower types
		{
			placementStop = !placementStop;
			this.SendMessage("PlacementStop", placementStop);
		}
	}
}
