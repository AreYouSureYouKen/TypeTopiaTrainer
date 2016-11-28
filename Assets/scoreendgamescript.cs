using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoreendgamescript : MonoBehaviour {
	
	Text txt;
	private int endscore = 10;
	public Learner lernurrr;
	bool toegevoegd = false;
	
	// Use this for initialization
	void Start () {
		txt = gameObject.GetComponent<Text>(); 
		txt.text="Score : " + PointCounter.score;
		lernurrr = GameObject.FindGameObjectWithTag("learner").GetComponent<Learner>();

	}
	
	// Update is called once per frame
	void Update () {
		if(!toegevoegd){
			setScore();
			toegevoegd = true;}

		//txt.text="Score : " + endscore;  
		//endscore = PlayerPrefs.GetInt("TOTALSCORE"); 
		//PlayerPrefs.SetInt("SHOWSTARTSCORE",endscore); 
	}

	public string setScore()
	{
		string url = "http://athena.fhict.nl/users/i292193/mathwars/saveHighscore.php?accountID=" + lernurrr.accountID + "&highscore=" + PointCounter.score;
		lernurrr.saveSumCount();
		WWW www = new WWW(url);
		while (!www.isDone)
		{

		}
		Debug.Log(lernurrr.accountID);
		Debug.Log(PointCounter.score);
		if (www.text == "")
		{
			return "Highscore bijgewerkt";
		}
		else
		{
			return www.text;
		}

	}
}
