using UnityEngine;
using System.Collections;
/*
This script is attached to a part of the tower, to determine it's spawn location


*/
public class TowerScript : MonoBehaviour {
	public object creep;
	public GameObject prefab;
	public Transform bullet;
	public int bulletName = 0;
	private float fireSpeed; //This needs to change depending on the tower type, in seconds
	//private Hashtable creepHash = new Hashtable();
	private float isActive;
	private bool fireActive = false;
	// Use this for initialization
	void Start () {
		//prefab =  Resources.Load ("Sphere") as GameObject;
		fireSpeed = 2;
		isActive = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Collider[] hitColliders = Physics.OverlapSphere(transform.position, 4);
		
        int i = 0;
        while (i < hitColliders.Length) {
			
			if (isActive == 0 && fireActive == true)
			{
				//Send the gameObject, rather than name
				GameObject myObject = Instantiate(prefab, transform.position,Quaternion.identity) as GameObject;
				myObject.SendMessage("TestMethod", hitColliders[i].gameObject);
				audio.Play();
				bulletName++;
				isActive++;	
			}
			
			
			//test1.transform.position = new Vector3(test1.transform.position.x + 1, test1.transform.position.y, test1.transform.position.z);
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
}
