using UnityEngine;
using System.Collections;

public class GameMenu : MonoBehaviour {
		
	void OnMouseEnter() {
		guiText.material.color = Color.yellow;
	}
	void OnMouseExit(){
		guiText.material.color = Color.white;	
	}
		
	void onMouseDown(){		
		
		
	}
	// Use this for initialization
	/*void Start () {
	
	}*/
	
	// Update is called once per frame
	void Update () {
	if(Input.GetMouseButton(0)){
			Application.LoadLevel("InGame");
		}
	}
	
	
}
