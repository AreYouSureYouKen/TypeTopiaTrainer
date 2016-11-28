using UnityEngine;
using System.Collections;

public class getTile : MonoBehaviour {
	
	public int number;
	public bool isFilled;
	bool removed = false;
	public bool correctTile = false;
	bool active = true;
	private GameObject blokje;
	private Transform parent;
	Ray ray;
	RaycastHit hit;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Debug.DrawLine(this.transform.position,Camera.main.transform.localPosition,Color.green);
		if (Physics.Raycast (this.transform.position, Camera.main.GetComponent<Camera>().transform.localPosition,out hit,10f) && active) {
			if (hit.collider.gameObject.tag == "blokje") {
				this.number = hit.collider.gameObject.GetComponent<textchanger> ().number;
				this.blokje = hit.collider.gameObject;
				if (parent == null)
				{
					this.parent = hit.collider.transform.parent;
				}
				isFilled = true;
				//hit.collider.transform.parent = null;
				//hit.collider.transform.localScale = new Vector3(0.115f, 0.115f, 0.115f);
				hit.collider.gameObject.transform.position = this.transform.position + new Vector3(0,0.1f,0);
				if (correctTile) {
					hit.collider.gameObject.GetComponent<textchanger> ().canPickup = false;
					hit.collider.transform.parent = null;
					Debug.Log("test");
					hit.collider.transform.localScale = new Vector3(0.115f, 0.115f, 0.115f);
					active = false;
					if(!removed){
						RetrieveNumbers.numberOfPlates--;
						removed=true;
					}
				}
			} 
			
			
			
			
		} else {
			if(!correctTile)
			{
			isFilled = false;
			if (blokje != null)
			{
				//blokje.transform.localScale = new Vector3(0.115f, 0.115f, 0.115f);
				blokje.transform.parent = parent;
				
				blokje = null;
			}
			
			this.number = -1;
			}
		} 
	}
}
