using UnityEngine;
using System.Collections;

public class HPBehaviourScript : MonoBehaviour 
{
	public int hp;
	
	// Use this for initialization
	void Start () 
	{
		guiText.text = hp.ToString();
	}
	
	void DamageHP()
	{
		hp = hp - 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
		guiText.text = hp.ToString();
		
		if(hp<=0)
		{
			Application.LoadLevel("GameOver");
		}
	}
}
