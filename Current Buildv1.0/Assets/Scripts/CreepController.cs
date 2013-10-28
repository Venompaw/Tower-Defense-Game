using UnityEngine;
using System.Collections;
using System;

public class CreepController : MonoBehaviour 
{
	public GameObject markers; 
	private Transform startMarker;
    private Transform endMarker;
    public float speed = 1.0F;
    private float startTime;
    private float journeyLength;
    public float smooth = 5.0F;
	public float health = 10.0F;
	private int previousMarker;
	public int coins = 10;
	
    void Start() 
	{
		previousMarker = 0;
		int next = previousMarker + 1;
		startMarker = markers.transform.Find("Path Node " + previousMarker);
		endMarker = markers.transform.Find("Path Node " + next);
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }
	
	void ApplyDamage(float damage)
	{
		health = health - damage;	
	}
	
    void Update() 
	{
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
		
		if (health <= 0)
		{
			//give player coins
			GameObject.Destroy(gameObject);
		}
		
		if (fracJourney >= 1.0F)
		{
			try
			{
			previousMarker = previousMarker +1;
			int next = previousMarker + 1;
			startMarker = markers.transform.Find("Path Node " + previousMarker);
			endMarker = markers.transform.Find("Path Node " + next);
        	startTime = Time.time;
        	journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
			}
			catch(Exception)
			{
				//player health reduced
				GameObject.Destroy(gameObject);
			}
		}
    }
}
