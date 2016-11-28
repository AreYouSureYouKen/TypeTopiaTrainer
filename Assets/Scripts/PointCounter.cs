using UnityEngine;
using System.Collections;

public class PointCounter : MonoBehaviour {

	public bool finished;
	public int maxScore;
	public int time;
	public int multipliers;
	static public int score;
	public RetrieveNumbers retrieve;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(finished)
		{
			time = (int)retrieve.timeLeft;
			score = TopiaCalc();
			Application.LoadLevel("eindlevel");
		}
	}

	public int rawCalc()
	{
		return (maxScore - time);
	}

	public int TopiaCalc()
	{
		int rawScore = rawCalc();
		int convertedScore = rawScore / 5 * (multipliers /2);
		if(convertedScore < 5)
		{
			convertedScore = 5;
		}
		return convertedScore;
	}
}


/*what to do:
 * check finished
 * check timer
 * timer to int
 * maxscore - timerint
 * omzetten naar topiamunten
*/