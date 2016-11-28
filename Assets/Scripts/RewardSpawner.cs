using UnityEngine;
using System.Collections;

public class RewardSpawner : MonoBehaviour {

	public middlescript m1;
	public middlescript m2;
	public middlescript m3;
	public middlescript m4;
	public middlescript m5;
	public middlescript m6;
	public GameObject reward1;
	public GameObject reward2;
	public GameObject reward3;
	public GameObject reward4;
	public GameObject reward5;
	public GameObject reward6;
	public GameObject reward7;
	public GameObject reward8;
	public GameObject reward9;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(m1.blokCompleet)
		{
			reward1.SetActive(true);
			reward3.SetActive(true);
			reward8.SetActive(true);
			reward9.SetActive(true);
		}
		if(m2.blokCompleet)
		{
			reward4.SetActive(true);
			reward5.SetActive(true);
			reward3.SetActive(true);
			reward9.SetActive(true);
		}
		if(m3.blokCompleet)
		{
			reward4.SetActive(true);
			reward5.SetActive(true);
			reward6.SetActive(true);
		}
		if(m4.blokCompleet)
		{
			reward3.SetActive(true);
			reward2.SetActive(true);
			reward8.SetActive(true);
		}
		if(m5.blokCompleet)
		{
			reward3.SetActive(true);
			reward5.SetActive(true);
			reward7.SetActive(true);
		}
		if(m6.blokCompleet)
		{
			reward5.SetActive(true);
			reward6.SetActive(true);
			reward7.SetActive(true);
		}
//		if(m1.blokCompleet && m2.blokCompleet && m4.blokCompleet && m5.blokCompleet)
//		{
//			reward7.SetActive(true);
//		}
//		if(m2.blokCompleet && m3.blokCompleet && m5.blokCompleet && m6.blokCompleet)
//		{
//			reward8.SetActive(true);
//		}
	}
}
