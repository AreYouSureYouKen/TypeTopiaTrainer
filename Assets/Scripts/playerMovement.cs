using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class playerMovement : MonoBehaviour {


		
	//public Transform[] waypoint;      
		//public List<GameObject> myList = new List<GameObject>();
		//public GameObject startloc;
		public float patrolSpeed = 3f;      
		//public bool  loop = true;       
		//public float dampingLook= 6.0f;          
		//public float pauseDuration = 60f;   
		//public float Dist;
		//public float tmpDist;
		//public int bestWaypoint;
		//public int currentWaypoint;
		//private float curTime;
		//private int currentWaypoint = 1;
		//public Vector3 target;
		public  bool startRunning =  false;	
		public GameObject finish;

		
		void  Update (){
			
		if(startRunning)transform.position = Vector3.MoveTowards(transform.position,finish.transform.position,patrolSpeed * Time.deltaTime );
		}/*
		void FindClosest () {
			//Dist = Mathf.Infinity;
			/*Dist = (waypoint[0].transform.position - transform.position).sqrMagnitude;			
			//bestWaypoint = 0;
			
			for (int i=2; i < waypoint.Length; i++) {
				tmpDist = (waypoint[i].position - this.transform.position).sqrMagnitude;
				if (tmpDist < Dist){
					Dist = tmpDist;
					currentWaypoint = i;
					Debug.Log(waypoint[i]);
				}
			else if(tmpDist == Dist && i > priority){
				priority = i;
				currentWaypoint = i;
				Debug.Log(waypoint[i]);
				}
			}*
		currentWaypoint = 1;
		this.transform.position = startloc.transform.position;
		}
		void  patrol (){
			
			target = myList[currentWaypoint].transform.position;
	
			target.y = transform.position.y; 
			Vector3 moveDirection = target - transform.position;			

			if(moveDirection.magnitude < 0.5f){
				if (curTime == 0)
					curTime = Time.time; 
				if ((Time.time - curTime) >= pauseDuration){
					currentWaypoint++;
					
					curTime = 0;
				}
			}else{        
				Quaternion rotation = Quaternion.LookRotation(target - transform.position);
				transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * dampingLook);				
				transform.position = Vector3.MoveTowards(transform.position, target,patrolSpeed * Time.deltaTime );
			} 
		}*/
	}