using UnityEngine;
using System.Collections;
using System;

public class CreepController : MonoBehaviour 
{
	public GameObject markers; 
	private Transform gold;
	private Transform startMarker;
    private Transform endMarker;
    public float speed = 1.0F;
    private float startTime;
    private float journeyLength;
    public float smooth = 5.0F;
	public float health = 10.0F;
	private int previousMarker;
	public float coins = 10;
	
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
	
	void AddParent(Transform hitPoints)
	{
		if (transform.parent == null)
		{
			transform.parent = hitPoints;
		}
	}
	
	void AddGold(Transform gold)
	{
		this.gold = gold;
	}
	
	void SetDifficulty(int difficulty)
	{
		switch (difficulty)
		{
		case 0:
			ModifyHealth(0.5f);
			break;
		case 1:
			break;
		case 2:
			ModifyHealth(2f);
			break;
		}
	}
	
	void ModifyHealth(float mod)
	{
		health = health * mod;
	}
	
	void ModifySpeed(float mod)
	{
		speed = speed * mod;
	}
	void ModifyCoins(float mod)
	{
		coins = coins * mod;
	}
			
	
    void Update() 
	{
		if (health <= 0)
		{
			gold.SendMessage("GoldIncrement", coins);
			GameObject.Destroy(gameObject);
		}
		
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
		
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
				SendMessageUpwards("DamageHP");
				GameObject.Destroy(gameObject);
			}
		}
    }
}
