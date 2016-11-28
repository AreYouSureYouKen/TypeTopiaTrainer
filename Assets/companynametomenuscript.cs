using UnityEngine;
using System.Collections;

public class companynametomenuscript : MonoBehaviour {

	public float timer = 0f;
	private float timetowait = 0.25f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		timer += 0.1f * Time.deltaTime;

		if(timer > timetowait)
		{
			Application.LoadLevel(1); // Plaats hier de link naar het spel
		}


	}

	public void Clickcompanyname() {
		Application.LoadLevel (1);
	}


	//


}
