using UnityEngine;
using System.Collections;

public class TowerSpawnScript : MonoBehaviour {
	
	public GameObject towerPrefab;
	public Camera camera;
	private bool placementStop;
	public GameObject ground;
	bool isActive; //False places a tower, true causes the tower to follow the mouse.
	GameObject towerObject;
	Vector3 objectPos;
	
	// Use this for initialization
	void Start () {
		towerObject = Instantiate(towerPrefab, objectPos, Quaternion.identity) as GameObject;
		isActive = true;
		placementStop = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(placementStop == false)
		{
			Vector3 mousePos = Input.mousePosition;
			mousePos.z = -camera.transform.position.z; //Z has to be negative
       		objectPos = Camera.main.ScreenToWorldPoint(mousePos);
			objectPos.y = 0;//Stops towers from spawning below the plane
			if (isActive == false)
			{
				if(towerObject != null)
				towerObject.BroadcastMessage("FireActive");//Allows the placed tower to begin firing
				//Add instantiations for different tower types
      			towerObject = Instantiate(towerPrefab, objectPos, Quaternion.identity) as GameObject;
				isActive = true;
			}
			else
			{
				if(towerObject != null)
				towerObject.BroadcastMessage("FollowMouse", objectPos);
			}
		}
		
		else
		{
			if (towerObject != null)
			towerObject.BroadcastMessage("DestroyTower");//Destroys the tower currently following the mouse
		}
	}
	
	public void PlaceTower(bool isActive)
	{
		this.isActive = isActive;
	}
	
	public void PlacementStop(bool placementStop)//Toggle placement
	{
		this.placementStop = placementStop;
		isActive = placementStop;
	}
}
