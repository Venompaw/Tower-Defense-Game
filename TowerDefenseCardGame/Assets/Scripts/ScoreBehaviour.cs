using UnityEngine;
using System.Collections;

public class ScoreBehaviour : MonoBehaviour {
	
	public float score;
	

	// Use this for initialization
	void Start () {
		guiText.text = "Score: " + score.ToString("F0");
	
	}
	bool ScoreDecrement(float scoreDecrease)
	{
		if(score>0)
		{
			score = score-scoreDecrease;
			return true;
		}
		return true;
	}
	void OnGUI()
	{
		if(ScoreDecrement(0.1f))
		{
			
		}
	}
	// Update is called once per frame
	void Update () {
			
		
		guiText.text = "Score: " + score.ToString("F0");
	}
}
