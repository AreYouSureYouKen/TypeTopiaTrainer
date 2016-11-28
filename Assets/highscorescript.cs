using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class highscorescript : MonoBehaviour {

	public Text nr1textvariable;
	public Text nr2textvariable;
	public Text nr3textvariable;
	public Text nr4textvariable;
	public Text nr5textvariable;


	// Use this for initialization
	void Start () {
		WWW www = new WWW("http://athena.fhict.nl/users/i292193/mathwars/getHighScores.php");
		while(!www.isDone)
		{

		}
		string[] scores = www.text.Split(';');
		//nr1textvariable = gameObject.GetComponent<Text>(); 
		if(scores.Length >= 1)
		nr1textvariable.text="#1 Score : " + scores[0];

		//nr2textvariable = gameObject.GetComponent<Text>();
		if(scores.Length >= 2)
			nr2textvariable.text="#2 Score : " + scores[1];

		//nr3textvariable = gameObject.GetComponent<Text>(); 
		if(scores.Length >= 3)
			nr3textvariable.text="#3 Score : " + scores[2];

		//nr4textvariable = gameObject.GetComponent<Text>(); 
		if(scores.Length >= 4)
			nr4textvariable.text="#4 Score : " + scores[3];

		//nr5textvariable = gameObject.GetComponent<Text>(); 
		if(scores.Length >= 5)
			nr5textvariable.text="#5 Score : " + scores[4];

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
