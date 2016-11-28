using UnityEngine;
using System.Collections;

public class endofgamescript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void nextlevel()
	{
		Application.LoadLevel ("generator"); // fill in the Next levels name or number
	}

	public void hoofdmenu()
	{
		Application.LoadLevel ("mainmenu");
	}

}
