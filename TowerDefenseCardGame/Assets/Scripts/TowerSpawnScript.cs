using UnityEngine;
using System.Collections;

public class TowerSpawnScript : MonoBehaviour {
	
	public GameObject towerPrefab;
	public Camera camera;
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
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = -camera.transform.position.z;
		text1.text = mousePos.ToString();
       	objectPos = Camera.main.ScreenToWorldPoint(mousePos);
		objectPos.y = 0;
		text2.text = isActive.ToString();
		if (isActive == false)
		{
			towerObject.BroadcastMessage("FireActive");
      		towerObject = Instantiate(towerPrefab, objectPos, Quaternion.identity) as GameObject;
			isActive = true;
		}
		else
		{
			towerObject.BroadcastMessage("FollowMouse", objectPos);
			
		}
	}
	
	public void PlaceTower(bool isActive)
	{
		this.isActive = isActive;
	}
}
