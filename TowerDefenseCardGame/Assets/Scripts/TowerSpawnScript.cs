using UnityEngine;
using System.Collections;

public class TowerSpawnScript : MonoBehaviour {
	
	public GameObject towerPrefab;
	public Camera camera;
	public bool testStop;
	public GameObject ground;
	public GUIText text1;
	public GUIText text2;
	bool isActive;
	GameObject towerObject;
	Vector3 objectPos;
	
	// Use this for initialization
	void Start () {
	towerObject = Instantiate(towerPrefab, objectPos, Quaternion.identity) as GameObject;
			isActive = true;
		testStop = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(testStop == false)
		{
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = -camera.transform.position.z;
		text1.text = mousePos.ToString();
       	objectPos = Camera.main.ScreenToWorldPoint(mousePos);
		objectPos.y = 0;
		text2.text = isActive.ToString();
		if (isActive == false)
		{
				if(towerObject != null)
			towerObject.BroadcastMessage("FireActive");
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
			towerObject.BroadcastMessage("DestroyTower");
		}
	}
	
	public void PlaceTower(bool isActive)
	{
		this.isActive = isActive;
	}
	
	public void TestStop(bool testStop)
	{
		this.testStop = testStop;
		isActive = testStop;
	}
}
