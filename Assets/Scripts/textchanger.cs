using UnityEngine;
using System.Collections;

public class textchanger : MonoBehaviour {

	// Use this for initialization
	public int number = 2;
	public bool canPickup = true;

	void Start () {
		GetComponentInChildren<TextMesh>().text = number.ToString();


	}
    
	// Update is called once per frame
	void Update () {
		if (!canPickup) {			
			GetComponent<Renderer>().material.color = Color.green;

		}

	
	}

}
