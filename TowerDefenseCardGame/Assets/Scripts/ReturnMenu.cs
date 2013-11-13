using UnityEngine;
using System.Collections;

public class ReturnMenu : MonoBehaviour {

	void OnMouseEnter()
	{
		guiText.material.color = Color.yellow;
		//if(Input.GetMouseButton(0))
		//{
			//Application.LoadLevel("GameMenu");
		//}
	}
	void OnMouseExit()
	{
		guiText.material.color = Color.white;
	}
	
	void OnMouseDown()
	{
		Application.LoadLevel("GameMenu");
	}
	
}
