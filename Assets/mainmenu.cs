using UnityEngine;
using System.Collections;

public class mainmenu : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void tutorialbutton(){
		Application.LoadLevel("tutorial"); // Plaats hier de link naar het spel
		Debug.Log ("Tutorial button");
	}
	
	
	public void highscorebutton(){
		Application.LoadLevel("highscorescene"); // Plaats hier de link naar het spel
		Debug.Log ("Highscore button");
	}
	
	public void exitbutton(){
		Application.Quit ();
		Debug.Log ("Exit button");
	}
	
}
