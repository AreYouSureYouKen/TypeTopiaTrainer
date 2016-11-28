using UnityEngine;
using System.Collections;

public class waypointSeeker : MonoBehaviour {
	public calcMovement mov;
	public PointCounter points;
	public GameObject waypoint1;
	public GameObject waypoint2;
	public GameObject waypoint3;
	public GameObject waypoint4;
	public GameObject waypoint5;
	public GameObject waypoint6;
	public GameObject waypointFinish;

	private bool step1 = true;
	private bool step2= false;
	private bool step3 = false;
	private bool step4 = false;
	private bool step5 = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	//if(buttonStart.pressed)
		{
			if(mov.pad1)
			{

				if(step1){
					if(Vector3.Distance(waypoint6.transform.position,this.transform.position)<.5)
					{
						Debug.Log("potato");
						step2 = true;
						step1 = false;
					}
					this.transform.position = Vector3.MoveTowards(this.transform.position,waypoint6.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				}
				if(step2){
					if(Vector3.Distance(waypoint3.transform.position,this.transform.position)<0.5)
					{
						Debug.Log("potato2");
						step3 = true;
						step2 = false;
					}
					this.transform.position = Vector3.MoveTowards(this.transform.position,waypoint3.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				}
				if(step3)
				{
					if(Vector3.Distance(waypoint2.transform.position,this.transform.position)<0.5)
					{
						step4 = true;
						step3 = false;
					}
					this.transform.position = Vector3.MoveTowards(this.transform.position,waypoint2.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				}
				if(step4)
				{
					if(Vector3.Distance(waypoint1.transform.position,this.transform.position)<0.5)
					{
						step5 = true;
						step4 = false;
					}
					this.transform.position = Vector3.MoveTowards(this.transform.position,waypoint1.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				}
				if(step5)
				{
					if(Vector3.Distance(waypointFinish.transform.position,this.transform.position)<0.5)
					{
						step5 = false;
						points.finished = true;
					}
					this.transform.position = Vector3.MoveTowards(this.transform.position,waypointFinish.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				}
			}
			else if(mov.pad2)
			{
				if(step1){
					if(Vector3.Distance(waypoint6.transform.position,this.transform.position)<1.1)
					{
						Debug.Log("potato");
						step2 = true;
						step1 = false;
					}
					this.transform.position = Vector3.MoveTowards(this.transform.position,waypoint6.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				}
				if(step2){
						if(Vector3.Distance(waypoint5.transform.position,this.transform.position)<1.1)
					{
						Debug.Log("potato2");
						step3 = true;
						step2 = false;
					}
					this.transform.position = Vector3.MoveTowards(this.transform.position,waypoint5.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				}
				if(step3)
				{
					if(Vector3.Distance(waypoint2.transform.position,this.transform.position)<0.5)
					{
						step4 = true;
						step3 = false;
					}
					this.transform.position = Vector3.MoveTowards(this.transform.position,waypoint2.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				}
				if(step4)
				{
					if(Vector3.Distance(waypoint1.transform.position,this.transform.position)<0.5)
					{
						step5 = true;
						step4 = false;
					}
					this.transform.position = Vector3.MoveTowards(this.transform.position,waypoint1.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				}
				if(step5)
				{
					if(Vector3.Distance(waypointFinish.transform.position,this.transform.position)<0.5)
					{
						step5 = false;
						points.finished = true;
					}
					this.transform.position = Vector3.MoveTowards(this.transform.position,waypointFinish.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				}
			}
			else if(mov.pad3)
			{
				if(step1){
					if(Vector3.Distance(waypoint6.transform.position,this.transform.position)<1.1)
					{
						Debug.Log("potato");
						step2 = true;
						step1 = false;
					}
					this.transform.position = Vector3.MoveTowards(this.transform.position,waypoint6.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				}
				if(step2){
					if(Vector3.Distance(waypoint5.transform.position,this.transform.position)<0.5)
					{
						Debug.Log("potato2");
						step3 = true;
						step2 = false;
					}
					this.transform.position = Vector3.MoveTowards(this.transform.position,waypoint5.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				}
				if(step3)
				{
					if(Vector3.Distance(waypoint4.transform.position,this.transform.position)<0.5)
					{
						step4 = true;
						step3 = false;
					}
					this.transform.position = Vector3.MoveTowards(this.transform.position,waypoint4.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				}
				if(step4)
				{
					if(Vector3.Distance(waypoint1.transform.position,this.transform.position)<0.5)
					{
						step5 = true;
						step4 = false;
					}
					this.transform.position = Vector3.MoveTowards(this.transform.position,waypoint1.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				}
				if(step5)
				{
					if(Vector3.Distance(waypointFinish.transform.position,this.transform.position)<0.5)
					{
						step5 = false;
						points.finished = true;
					}
					this.transform.position = Vector3.MoveTowards(this.transform.position,waypointFinish.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				}
			}
			else if(mov.pad4)
			{
				this.transform.position = Vector3.MoveTowards(this.transform.position,waypoint6.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				if(Vector3.Distance(waypoint6.transform.position,this.transform.position)<1.2)
				{
					Debug.Log("potato");
					this.transform.position = Vector3.MoveTowards(this.transform.position,waypoint3.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				}
				if(Vector3.Distance(waypoint3.transform.position,this.transform.position)<0.5)
				{
					Debug.Log("potato2");
					this.transform.position = Vector3.MoveTowards(this.transform.position,waypoint2.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				}
				if(Vector3.Distance(waypoint2.transform.position,this.transform.position)<0.5)
				{
					this.transform.position = Vector3.MoveTowards(this.transform.position,waypoint5.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				}
				if(Vector3.Distance(waypoint5.transform.position,this.transform.position)<0.5)
				{
					this.transform.position = Vector3.MoveTowards(this.transform.position,waypoint4.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				}
				if(Vector3.Distance(waypoint4.transform.position,this.transform.position)<0.5)
				{
					this.transform.position = Vector3.MoveTowards(this.transform.position,waypoint1.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				}
				if(Vector3.Distance(waypoint1.transform.position,this.transform.position)<0.5)
				{
					this.transform.position = Vector3.MoveTowards(this.transform.position,waypointFinish.transform.position+new Vector3(0,0.2f,0),3f*Time.deltaTime);
				}
				if(Vector3.Distance(waypointFinish.transform.position,this.transform.position)<0.5)
				{
					points.finished = true;
				}
			}

		}
	}
}
