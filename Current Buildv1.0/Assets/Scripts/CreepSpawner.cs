using UnityEngine;
using System.Collections;

public class CreepSpawner : MonoBehaviour 
{
	public GameObject prefab;
	public int numberOfObjects = 20;
	private float time;
	public float spawnDelay;
	private int i;
	
	// Use this for initialization
	void Start () 
	{
		time = Time.time;
		i = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (i < numberOfObjects && (Time.time - time) >= spawnDelay) 
		{
			i = i + 1;
			time = Time.time;
			Instantiate(prefab);
			//private GameObject creep = (GameObject)Instantiate(prefab);
			//creep.SendMessage("ApplyDamage", 1.0F);
		}
	}
}