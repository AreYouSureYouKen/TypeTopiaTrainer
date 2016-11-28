using UnityEngine;
using System.Collections;

public class checkFilled : MonoBehaviour {

	public bool isComplete = false;
	public int fillCount =0;
	public int value1=-1;
	public int value2=-1;
	public string operatorValue;
	public GameObject blok1;
	public GameObject blok2;
	public getTile  tile1;
	public getTile  tile2;
	public GameObject operatorblok;
	public getOperator  getOperatorTile;
	public GameObject equalsblok;


	// Use this for initialization
	void Start () {
		tile1 = blok1.GetComponent<getTile>();
		tile2 = blok2.GetComponent<getTile>();
		getOperatorTile = operatorblok.GetComponent<getOperator>();
		operatorblok.transform.localEulerAngles = this.transform.localEulerAngles;
		equalsblok.transform.localEulerAngles = this.transform.localEulerAngles;
		//Debug.Log(this.transform.localEulerAngles);
	}
	
	// Update is called once per frame
	void Update () {
		value1 = tile1.number;
		value2 = tile2.number;
		operatorValue = getOperatorTile.operatorType;
		if(value1 != -1 && value2 != -1){
			isComplete = true;
		} else isComplete = false;

	}

	public void Countup(){

		fillCount++;

	}

}