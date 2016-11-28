using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class usernameendgamescript : MonoBehaviour {
	
	Text txt;
	//private string username = "De Var username";
	
	// Use this for initialization	
	void Start () {
		txt = gameObject.GetComponent<Text>(); 
		txt.text="Goed gedaan " + Learner.Username;
	}
	
	// Update is called once per frame
	void Update () {
		//txt.text="Score : " + endscore;  
		//endscore = PlayerPrefs.GetInt("TOTALSCORE"); 
		//PlayerPrefs.SetInt("SHOWSTARTSCORE",endscore); 
	}
}
