using UnityEngine;
using System.Collections;

public class HPBehaviourScript : MonoBehaviour 
{
	public int hp;
	
	// Use this for initialization
	void Start () 
	{
		guiText.text = "Lives: " + hp.ToString();
	}
	
	void DamageHP()
	{
		hp = hp - 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(hp <= 0)
		{Application.LoadLevel("GameOver");
		}
		
		guiText.text = "Lives: " + hp.ToString();
	}
}
