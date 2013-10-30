using UnityEngine;
using System.Collections;

public class TowerScript : MonoBehaviour {
	public object creep;
	public GameObject prefab;
	public Transform bullet;
	public int bulletName = 0;
	private Hashtable creepHash = new Hashtable();
	private int isActive;
	// Use this for initialization
	void Start () {
		//prefab =  Resources.Load ("Sphere") as GameObject;
		isActive = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		Collider[] hitColliders = Physics.OverlapSphere(transform.position, 4);
		
        int i = 0;
        while (i < hitColliders.Length) {
			
			if (isActive == 0)
			{
				
				GameObject myObject = Instantiate(prefab, new Vector3(0, 2, 0),Quaternion.identity) as GameObject;
				myObject.SendMessage("TestMethod", hitColliders[i].gameObject.name);
				bulletName++;
				isActive++;
				
				
				
			}
			
			
			//test1.transform.position = new Vector3(test1.transform.position.x + 1, test1.transform.position.y, test1.transform.position.z);
            i++;
        }
		if (isActive != 0)
			{
				if (isActive > 50 || isActive < 0)
					isActive = 0;
				else
					isActive++;
			}
		
	}
	
}
