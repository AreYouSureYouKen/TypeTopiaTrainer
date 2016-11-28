using UnityEngine;
using System.Collections;

public class uitlegscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

		
		public void Clickstartgamebutton(){
			Application.LoadLevel("game");
		}

		public void Terugbutton(){
		Application.LoadLevel("mainmenu");
		}

	public void Terugnaarinlogbutton(){
		Application.LoadLevel("inlogscene");
	}
		
}


