using UnityEngine;
using System.Collections;

public class GoldBehaviour : MonoBehaviour {
	
	public float gold;
	public Transform errorText;
	// Use this for initialization
	void Start () {
		guiText.text = gold.ToString();
	}
	
	void OnGUI(){
		
		    if (GUI.Button(new Rect(1300, 230, 50, 50), "Tower"))
    {
			if(gold>300)
			{
				gold = gold - 300;
			}
			else
			{
				//errorText.guiText.text="Not enough gold!";
				errorText.SendMessage("DisplayMessage", "Not enough gold!");
			}
     
    }
	}
	
	// Update is called once per frame
	void Update () {
		
		guiText.text = gold.ToString();
	
	}
}
