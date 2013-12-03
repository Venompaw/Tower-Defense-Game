using UnityEngine;
using System.Collections;

public class GridPlacement : MonoBehaviour 
{
	private Transform selectedTower;
	private bool isEmpty;
	public GameObject cam;
	
	// Use this for initialization
	void Start () 
	{
		isEmpty = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnMouseUp () 
	{
		if (isEmpty && selectedTower != null)
		{
			selectedTower.position = transform.position;
			isEmpty = !isEmpty;
			ClearTower();
		}
	}
	
	void OnMouseOver ()
	{
		cam.BroadcastMessage("SetGridFull", !isEmpty);
	}
	
	public void SetTower (Transform tower)
	{
		selectedTower = tower;
	}
	
	public void ClearTower ()
	{
		selectedTower = null;
	}
}
