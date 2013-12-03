using UnityEngine;
using System.Collections;

public class TowerPlacement : MonoBehaviour {
		
	private PlaceableTower placeableTower;
	private Transform currentTower;
	private bool hasPlaced;
	public GameObject grid;
	private bool gridFull;
	
	public LayerMask towersMask;
	
	private PlaceableTower placeableTowerOld;
	
	// Update is called once per frame
	void Update () {
		
		Vector3 m = Input.mousePosition;
		m = new Vector3(m.x,m.y,transform.position.y);
		Vector3 p = camera.ScreenToWorldPoint(m);
		
		if (currentTower != null && !hasPlaced) {
			
			currentTower.position = new Vector3(p.x,0,p.z);
			
			if (Input.GetMouseButtonDown(0)) {
				if (IsLegalPosition()) {
					hasPlaced = true;	
				}
			}
		}
		else {
			/*
			if (Input.GetMouseButtonDown(0)) {
				RaycastHit hit = new RaycastHit();
				Ray ray = new Ray(new Vector3(p.x,8,p.z), Vector3.down);
				if (Physics.Raycast(ray, out hit,Mathf.Infinity,towersMask)) {
					if (placeableTowerOld != null) {
						placeableTowerOld.SetSelected(false);
					}
					hit.collider.gameObject.GetComponent<PlaceableTower>().SetSelected(true);
					placeableTowerOld = hit.collider.gameObject.GetComponent<PlaceableTower>();
				}
				else {
					if (placeableTowerOld != null) {
						placeableTowerOld.SetSelected(false);
					}
				}
			} */
		}
	}


	bool IsLegalPosition() {
		if (placeableTower.colliders.Count> 0 || gridFull) {
			return false;	
		}
		return true;
	}
	
	public void SetItem(GameObject b) {
		hasPlaced = false;
		currentTower = ((GameObject)Instantiate(b)).transform;
		placeableTower = currentTower.GetComponent<PlaceableTower>();
		grid.BroadcastMessage("SetTower", currentTower);
	}
	
	public void SetGridFull(bool a)
	{
		gridFull = a;
	}
}
