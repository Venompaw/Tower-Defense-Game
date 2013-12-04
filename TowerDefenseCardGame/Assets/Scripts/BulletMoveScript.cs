using UnityEngine;
using System.Collections;

public class BulletMoveScript : MonoBehaviour {
	
	//private string creepID;
	public GUIText guiText;
	private GameObject creepObject;
	private float damage;
	//public ParticleSystem particleSystem;
	// Use this for initialization
	void Start () {
		//transform.position = new Vector3(transform.position.x, creepObject.transform.position.y, transform.position.z);
		//damage = 50.0f;//In case of errors, will stop from being null
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(creepObject == null)
		{
			Destroy(gameObject);
		}
		
		transform.LookAt(new Vector3(creepObject.transform.position.x, creepObject.transform.position.y, creepObject.transform.position.z));
		transform.Rotate(0, 90, 90);
			
		transform.position = Vector3.MoveTowards(transform.position, creepObject.transform.position, 
			12.0f * Time.deltaTime);
		
		if(transform.position == creepObject.transform.position)
		{
			creepObject.SendMessage("ApplyDamage", damage);
			Destroy(gameObject);
		}
		
		//ApplyDamage
		//Destroy(this);
	}
	
	public void TestMethod(GameObject creepObject)
	{	//Accept a gameObject
		this.creepObject = creepObject;
	}
	
	public void DamageMethod(float damage)
	{
		this.damage = damage;
	}
}
