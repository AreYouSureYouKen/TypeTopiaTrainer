using UnityEngine;
using System.Collections;

public class resetPos : MonoBehaviour {

	// Use this for initialization
	//public Camera cam;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	if(GetComponentInParent<zoom>().zoomedIn == true){
			//this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y-1f,1.899441f);
			//this.transform.localEulerAngles = new Vector3(90,0,0);
			this.transform.position = new Vector3(Camera.main.transform.position.x-3f,Camera.main.transform.position.y-9f,Camera.main.transform.position.z-3.25f);
			//this.transform.localEulerAngles = new Vector3(90,0,0);

		}
	 else{


		}/* if(this.transform.position.y != 0.3f)
		{
			this.transform.position = new Vector3(camera.transform.position.x,camera.transform.position.y-6f);
			this.transform.localEulerAngles = new Vector3(90,0,0);
		}*/
	}
}
