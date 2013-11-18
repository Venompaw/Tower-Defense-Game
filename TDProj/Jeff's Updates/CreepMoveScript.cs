using UnityEngine;
using System.Collections;

public class CreepMoveScript : MonoBehaviour {
	// Use this for initialization
	public float health = 10F;
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y, transform.position.z);
		if (health <= 0)
		{
			//give player coins
			GameObject.Destroy(gameObject);
		}
		
		
	}
	
	void ApplyDamage(float damage)
	{
		health = health - damage;	
	}
}
