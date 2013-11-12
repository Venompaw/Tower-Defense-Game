using UnityEngine;
using System.Collections;

public class GoldBehaviour : MonoBehaviour {
	
	public float gold;
	
	public Transform errorText;
	// Use this for initialization
	void Start () {
		guiText.text = "Gold: " + gold.ToString();
	}
	
	void OnGUI(){
		
		    if (GUI.Button(new Rect(1300, 230, 50, 50), "Tower"))
    {
			if(GoldDecrement(300))
			{
				//Place tower
			}
			else
			{
				//errorText.guiText.text="Not enough gold!";
				errorText.SendMessage("DisplayMessage", "Not enough gold!");
			}
     
    }
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
		
		guiText.text = "Gold: " + gold.ToString();
	
	}
}
