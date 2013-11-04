using UnityEngine;
using System.Collections;

public class GoldBehaviour : MonoBehaviour {
	
	public float gold;
	
	public Transform errorText;
	// Use this for initialization
	void Start () {
		guiText.text = gold.ToString();
	}
		
	
	
	bool GoldDecrement(float goldDecrease)
	{
		if(gold>goldDecrease)
			{
				gold = gold-goldDecrease;
			return true;
			}
			return false;
		
	}
	
	void GoldIncrement(float goldIncrease)
	{
		gold = gold+goldIncrease;
	}
	// Update is called once per frame
	void Update () {
		
		guiText.text = gold.ToString();
	
	}
}
