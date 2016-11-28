using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class middlescript : MonoBehaviour {
	public int randomNumber;
	private GameObject Boven;
	private GameObject Onder;
	private GameObject Rechts;
	private GameObject Links;
	private checkFilled checkBoven;
	private checkFilled checkRechts;
	private checkFilled checkOnder;
	private checkFilled checkLinks;
	private GameObject waypointSpawn;
	public GameObject stone;

	public bool bovenDone;
	public bool onderDone;
	public bool linksDone;
	public bool rechtsDone;

	private bool sendbovenDone;
	private bool sendonderDone;
	private bool sendlinksDone;
	private bool sendrechtsDone;
	public bool blokCompleet;
	public Component[] getTiles;
	public GameObject GameManager;

	public GameObject prefabPlus;
	public GameObject prefabMin;
	public GameObject prefabDeel;
	public GameObject prefabKeer;
	private GameObject BlockBoven;
	private GameObject BlockOnder;
	private GameObject BlockRechts;
	private GameObject BlockLinks;
	public GameObject hoek1;
	public GameObject hoek2;
	public GameObject hoek3;
	public GameObject hoek4;
	public GameObject waypointGameobject;
	public GameObject player;
	public bool setmiddle = false;
	public PointCounter points;
	public Learner lernehr;

	// Use this for initialization
	void Start () {
		lernehr = GameObject.FindGameObjectWithTag("learner").GetComponent<Learner>();

	}

    public int instantiation(List<string> operators)
    {
        randomNumber = Random.Range(1, 41);
        //randomNumber = 17;
        GetComponentInChildren<TextMesh>().text = randomNumber.ToString();

        Boven = Instantiate(getPrefab(operators[0]), hoek1.transform.position, hoek1.transform.rotation) as GameObject;
        Onder = Instantiate(getPrefab(operators[1]), hoek2.transform.position, hoek2.transform.rotation) as GameObject;
        Links = Instantiate(getPrefab(operators[2]), hoek3.transform.position, hoek3.transform.rotation) as GameObject;
        Rechts = Instantiate(getPrefab(operators[3]), hoek4.transform.position, hoek4.transform.rotation) as GameObject;
        Boven.transform.parent = transform;
        Onder.transform.parent = transform;
        Links.transform.parent = transform;
        Rechts.transform.parent = transform;

        checkBoven = Boven.GetComponent<checkFilled>();
        checkRechts = Rechts.GetComponent<checkFilled>();
        checkLinks = Links.GetComponent<checkFilled>();
        checkOnder = Onder.GetComponent<checkFilled>();
        return randomNumber;
    }

    GameObject getPrefab(string operand)
    {
        switch (operand)
        {
            case "+":
                return prefabPlus;
            case "-":
                return prefabMin;
            case "x":
                return prefabKeer;
            case ":":
                return prefabDeel;
            default:
                return null;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (randomNumber != 0)
        {
            if (bovenDone && rechtsDone && linksDone && onderDone)
            {
                GetComponent<Renderer>().material.color = Color.green;
                //GameManager.GetComponent<RetrieveNumbers>().blokcompleet=true;
            }
			while(checkBoven == null || checkLinks == null || checkRechts==null||checkOnder==null)
			{
			}
            if (checkBoven.isComplete && !bovenDone)
            {
                //	Debug.Log ("Berekenen Boven");
                if (calculationTop())
                {
                    bovenDone = true;

                    if (!sendbovenDone)
                    {
                        getTiles = Boven.GetComponentsInChildren<getTile>();
                        foreach (getTile tiles in getTiles)
                        {
                            tiles.correctTile = true;
                        }
                        sendbovenDone = true;
                        
                    }
                }


            }
			if (checkRechts.isComplete && !rechtsDone){
                //Debug.Log ("Berekenen Rechts");
                if (calculationRight())
                {
                    rechtsDone = true;
                    if (!sendrechtsDone)
                    {
                        getTiles = Rechts.GetComponentsInChildren<getTile>();
                        foreach (getTile tiles in getTiles)
                        {
                            tiles.correctTile = true;
                        }
                        sendrechtsDone = true;
                       
                    }
                }


            }

		if (checkLinks.isComplete && !linksDone)//onderwtf
            {
                if (calculationLeft())
                {
                    linksDone = true;
                    if (!sendlinksDone)
                    {
                        getTiles = Links.GetComponentsInChildren<getTile>();
                        foreach (getTile tiles in getTiles)
                        {
                            tiles.correctTile = true;
                        }
                        sendlinksDone = true;
                        
                    }
                }


            }
		
		if (checkOnder.isComplete  && !onderDone)//rechts lol
            {
                //Debug.Log ("Berekenen Onder");
                if (calculationDown())
                {
                    onderDone = true;
                    if (!sendonderDone)
                    {
                        getTiles = Onder.GetComponentsInChildren<getTile>();
                        foreach (getTile tiles in getTiles)
                        {
                            tiles.correctTile = true;
                        }
                        sendonderDone = true;
                        
                    }
                }


			}}
            checkComplete();
        }


	bool calculationTop(){

		if(checkBoven.operatorValue == "+" )
		{
			if(randomNumber == (checkBoven.value1 + checkBoven.value2))
			{
				lernehr.addSum("+");
				return true;
			}
			else return false;
				
	  	}
		else if(checkBoven.operatorValue == "-")
		{
			if(randomNumber == (checkBoven.value2 - checkBoven.value1))
			{
				lernehr.addSum("-");
				return true;
			}
			else return false;
		}
		else if(checkBoven.operatorValue == "x")
		{
			if(randomNumber == (checkBoven.value1 * checkBoven.value2))
			{
				lernehr.addSum("x");
				return true;
			}
			else return false;
		}
		else if(checkBoven.operatorValue == ":")
		{
			if(randomNumber == (checkBoven.value2 / checkBoven.value1))
			{
				lernehr.addSum(":");
				return true;
			}
			else return false;
		}

		else return false;
	}

	bool calculationLeft(){
	
		if(checkLinks.operatorValue == "+" )
		{
			if(randomNumber == (checkLinks.value1 + checkLinks.value2))
			{
				lernehr.addSum("+");
				return true;
			}
			else return false;
			
		}
		else if(checkLinks.operatorValue == "-")
		{
			if(randomNumber == (checkLinks.value1 - checkLinks.value2))
			{
				lernehr.addSum("-");
				return true;
			}
			else return false;
		}
		else if(checkLinks.operatorValue == "x")
		{
			if(randomNumber == (checkLinks.value1 * checkLinks.value2))
			{
				lernehr.addSum("x");
				return true;
			}
			else return false;
		}
		else if(checkLinks.operatorValue == ":")
		{
			if(randomNumber == (checkLinks.value1 / checkLinks.value2))
			{
				lernehr.addSum(":");
				return true;
			}
			else return false;
		}
		
		else return false;
	}


	bool calculationRight(){

		if(checkRechts.operatorValue == "+" )
		{
			if(randomNumber == (checkRechts.value1 + checkRechts.value2))
			{
				lernehr.addSum("+");
				return true;
			}
			else return false;
			
		}
		else if(checkRechts.operatorValue == "-")
		{
			if(randomNumber == (checkRechts.value2 - checkRechts.value1))
			{
				lernehr.addSum("-");
				return true;
			}
			else return false;
		}
		else if(checkRechts.operatorValue == "x")
		{
			if(randomNumber == (checkRechts.value1 * checkRechts.value2))
			{
				lernehr.addSum("x");
				return true;
			}
			else return false;
		}
		else if(checkRechts.operatorValue == ":")
		{
			if(randomNumber == (checkRechts.value2 / checkRechts.value1))
			{
				lernehr.addSum(":");
				return true;
			}
			else return false;
		}
		
		else return false;
	}


	bool calculationDown(){

		if(checkOnder.operatorValue == "+" )
		{
			if(randomNumber == (checkOnder.value1 + checkOnder.value2))
			{
				lernehr.addSum("+");
				return true;
			}
			else return false;
			
		}
		else if(checkOnder.operatorValue == "-")
		{
			if(randomNumber == (checkOnder.value1 - checkOnder.value2))
			{
				lernehr.addSum("-");
				return true;
			}
			else return false;
		}
		else if(checkOnder.operatorValue == "x")
		{
			if(randomNumber == (checkOnder.value1 * checkOnder.value2))
			{
				lernehr.addSum("x");
				return true;
			}
			else return false;
		}
		else if(checkOnder.operatorValue == ":")
		{
			if(randomNumber == (checkOnder.value1 / checkOnder.value2))
			{
				lernehr.addSum(":");
				return true;
			}
			else return false;
		}
		
		else return false;
	}

	void checkComplete()
	{
		if(onderDone && rechtsDone && bovenDone && linksDone && !blokCompleet)
		{
			points.multipliers++;
			blokCompleet = true;
		}
	}
}

