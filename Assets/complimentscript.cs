using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class complimentscript : MonoBehaviour {
	
	Text txt;
	private int endscore = 10;
	
	// Use this for initialization
	void Start () {
		txt = gameObject.GetComponent<Text>(); 
		txt.text="Score : " + endscore;
	}
	
	// Update is called once per frame
	void Update () {
		//txt.text="Score : " + endscore;  
		//endscore = PlayerPrefs.GetInt("TOTALSCORE"); 
		//PlayerPrefs.SetInt("SHOWSTARTSCORE",endscore); 
	}
}
