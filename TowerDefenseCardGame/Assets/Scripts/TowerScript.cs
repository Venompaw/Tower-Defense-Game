using UnityEngine;
using System.Collections;

public class TowerScript : MonoBehaviour {
	public object creep;
	public GameObject prefab;
	public Transform bullet; 
	public int bulletName;
	private float fireSpeed; //The time between each tower firing, in seconds
	private float isActive; //When equal to fireSpeed, resets and allows the tower to fire again
	private bool fireActive; //Stops the tower from firing until placed
	
	
	// Use this for initialization
	void Start () {
		bulletName = 0;
		fireActive = false;
		fireSpeed = 2;
		isActive = 0;
	}
	
	void FixedUpdate () {
		Collider[] hitColliders = Physics.OverlapSphere(transform.position, 4);
		
        int i = 0;
        while (i < hitColliders.Length) {
			if (isActive == 0 && fireActive == true)
			{
				GameObject bulletObject = Instantiate(prefab, transform.position,Quaternion.identity) as GameObject;
				bulletObject.SendMessage("TestMethod", hitColliders[i].gameObject);
				audio.Play();
				bulletName++;
				isActive++;	
			}
            i++;
        }
		if (isActive != 0)
			{
				if (isActive > fireSpeed || isActive < 0)
					isActive = 0;
				else
					isActive += Time.deltaTime;
			}
	}
	
	public void DestroyTower()
	{
		Destroy(gameObject);
	}
	
	public void FollowMouse(Vector3 objectPos)
	{
		objectPos.y = 2.0f;
		transform.position = objectPos;
	}
	
	public void FireActive()
	{
		fireActive = !fireActive;
	}
	
	public void TowerType(string towerType)
	{
		switch (towerType)
		{	
		case "ArcherTower":
			fireSpeed = 2f;
			break;
		case "ArrowCart":
			fireSpeed = 1f;
			break;
		case "Ballista":
			fireSpeed = 2.2f;
			break;
		}
	}
}
