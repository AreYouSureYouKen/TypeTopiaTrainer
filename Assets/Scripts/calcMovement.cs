using UnityEngine;
using System.Collections;

public class calcMovement : MonoBehaviour {


	public middlescript middle1;
	public middlescript middle2;
	public middlescript middle3;
	public middlescript middle4;
	public middlescript middle5;
	public middlescript middle6;

	public Camera cam;
	public GameObject player;

	public bool pad1 = false;
	public bool pad2 = false;
	public bool pad3 = false;
	public bool pad4 = false;
	public bool follow = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(follow)
		{
			playerCam();
		}
		/*route1*/
		if(standardDone()
		   &&bind36 ()
		   &&bind23 ()
		   &&bind12 ())
		{
			Debug.Log("route1 af");
			pad1 = true;
			follow = true;
		}
		/*route2*/
		else if(standardDone()
		        && bind56 ()
		        && bind12()
		        && bind25 ())
		{
			Debug.Log("route2 af");
			pad2 = true;
			follow = true;
		}
		/*route3*/
		else if(standardDone()
		        && bind56()
		        && bind45() 
		        && bind14())
		{
			Debug.Log("route3 af");
			pad3 = true;
			follow = true;
		}
		/*route4*/
		else if(standardDone() 
		   && bind36 ()
		   && bind23()
		   && bind25()
		   && bind45 ()
		   && bind14 ())
		{
			Debug.Log("route4 af");
			pad4 = true;
			follow = true;

		}


	}
	bool standardDone()
	{
		if(middle1.rechtsDone && middle6.onderDone)
		{
			Debug.Log ("stan");
			return true;
		}
		return false;
	}
	bool bind12()
	{
		if(middle1.onderDone && middle2.rechtsDone)
		{
			Debug.Log ("12");
			return true;
		}
		
		return false;
	}
	bool bind23()
	{
		if(middle2.onderDone && middle3.rechtsDone)
		{
			Debug.Log ("23");
			return true;
		}
		
		return false;
	}
	bool bind36()
	{
		if(middle3.linksDone && middle6.bovenDone)
		{
			Debug.Log ("36");
			return true;
		}
		
		return false;
	}
	bool bind25()
	{
		if(middle2.linksDone && middle5.bovenDone)
		{
			Debug.Log ("25");
			return true;
		}
		
		return false;
	}
	bool bind14()
	{
		if(middle1.linksDone && middle4.bovenDone)
		{
			Debug.Log ("14");
			return true;
		}
		
		return false;
	}
	bool bind45()
	{
		if(middle4.onderDone && middle5.rechtsDone)
		{
			Debug.Log ("45");
			return true;
		}
		
		return false;
	}
	bool bind56()
	{
		if(middle5.onderDone && middle6.rechtsDone)
		{
			Debug.Log ("56");
			return true;
		}
		
		return false;
	}

	void playerCam(){
		cam.transform.position = player.transform.position + new Vector3(0,9,0);
	}
}


 

/*
 * boven=boven
 * onder= rechts
 * links= onder
 * rechts = links
 *geven iedere weg hardcoded weer
 *if statement in update
 *als alles klopt knop groen
 *klik start om te rennen
 */