using UnityEngine;
using System.Collections;

public class CreepSpawner : MonoBehaviour 
{
	public GameObject[] prefab;
	public int[] amountInRound;
	public float[] spawnDelay;
	private float[] time;
	private int[] roundCounter;
	private GameObject creep;
	public Transform hitPoints;
	private int round;
	
	// Use this for initialization
	void Start () 
	{
		round = 0;
		time = new float[prefab.Length];
		roundCounter = new int[prefab.Length];
	}
	
	// Update is called once per frame
	void Update () 
	{
		int i = 0;
		while (i < round)
		{
			if (roundCounter[i] < amountInRound[i] && (Time.time - time[i]) >= spawnDelay[i]) 
			{
				time[i] = Time.time;
				roundCounter[i] = roundCounter[i] + 1;
				creep = (GameObject)Instantiate(prefab[i]);
				creep.SendMessage("AddParent", hitPoints);
			}
			else
			{
				i = i + 1;
			}
		}
	}
	
	void StartRound()
	{
		time[round] = Time.time;
		round = round + 1;
	}
}