using UnityEngine;
using System.Collections;

public class GameMenu : MonoBehaviour {
	public static int difficulty;
		
	void OnMouseEnter() {
		guiText.material.color = Color.yellow;
	}
	void OnMouseExit(){
		guiText.material.color = Color.white;	
	}
		
	void OnMouseDown()
	{		
		switch (guiText.text)
		{
		case "Easy":
			difficulty = 0;
			break;
		case "Medium":
			difficulty = 1;
			break;
		case "Hard":
			difficulty = 2;
			break;
		}
		Application.LoadLevel("InGame");
		
	}
	
}
