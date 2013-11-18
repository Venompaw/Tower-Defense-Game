using UnityEngine;
using System.Collections;

public class BulletMoveScript : MonoBehaviour {
	
	//private string creepID;
	public GUIText guiText;
	private GameObject creepObject;
	// Use this for initialization
	void Start () {
		
		/*   B instanceOfB = GameObject.Find("Name of GameObject to which B is attached").GetComponent<B>();
        		instanceOfB.printStuff("this is b's method");
   				 }
					
					*/
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(creepObject == null)
		{
			Destroy(gameObject);
		}
		transform.position = Vector3.MoveTowards(transform.position, creepObject.transform.position, 
			5.0f * Time.deltaTime);
		
		if(transform.position == creepObject.transform.position)
		{
			creepObject.SendMessage("ApplyDamage", 20.0f);
			Destroy(gameObject);
		}
		
		//ApplyDamage
		//Destroy(this);
	}
	
	public void TestMethod(GameObject creepObject)
	{	//Accept a gameObject
		this.creepObject = creepObject;
	}
}
