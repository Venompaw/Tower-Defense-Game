using UnityEngine;
using System.Collections;

public class GameMenu : MonoBehaviour {
		
	void OnMouseEnter() {
		guiText.material.color = Color.yellow;
	}
	void OnMouseExit(){
		guiText.material.color = Color.white;	
	}
		
	void OnMouseDown()
	{		
		Application.LoadLevel("InGame");		
	}	
	
}
