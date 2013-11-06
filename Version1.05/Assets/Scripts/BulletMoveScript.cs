using UnityEngine;
using System.Collections;

public class BulletMoveScript : MonoBehaviour {
	
	private string creepID;
	public GUIText guiText;
	// Use this for initialization
	void Start () {
		
		/*   B instanceOfB = GameObject.Find("Name of GameObject to which B is attached").GetComponent<B>();
        		instanceOfB.printStuff("this is b's method");
   				 }
					
					*/
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = Vector3.MoveTowards(transform.position, GameObject.Find(creepID).
			transform.position, 5.0f * Time.deltaTime);
		
		if(transform.position == GameObject.Find(creepID).transform.position)
		{
			GameObject.Find(creepID).SendMessage("ApplyDamage", 1.0f);
			Destroy(gameObject);
		}
		//ApplyDamage
		//Destroy(this);
	}
	
	public void TestMethod(string creepID)
	{
		this.creepID = creepID;
	}
}
