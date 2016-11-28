using UnityEngine;

public class zoom : MonoBehaviour
{
	public float perspectiveZoomSpeed = 0.5f;        // The rate of change of the field of view in perspective mode.
	public float orthoZoomSpeed = 0.5f;        // The rate of change of the orthographic size in orthographic mode.
	public bool zoomedIn = false;
	public float speed = 0.1F;
	private float lastClickTime;
	private float catchTime = 0.25f;
	private Vector3 standardLocation;
	private Vector3 tapLocation;
	public RetrieveNumbers retrieve;
	public GameObject terugKnop;

	//public GameObject blokjesContainer;

	
	
	void Start(){
		standardLocation = this.transform.position;
	}
	
	void Update()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			if (Time.time - lastClickTime < catchTime)
			{
				//double click
				if (!zoomedIn)
				{
					RaycastHit hit;
					Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
					if (Physics.Raycast(ray, out hit))
						if (hit.collider.tag == "puzzle")
					{
						zoomedIn = true;
						terugKnop.SetActive(false);
						Vector3 center = hit.transform.localPosition;
						//blokjesContainer.transform.position = new Vector3(blokjesContainer.transform.position.x, blokjesContainer.transform.position.y + 9, blokjesContainer.transform.position.z + 4);
						transform.position = new Vector3(center.x, center.y + 9, center.z);
						if(hit.collider.name == "middle1")
							retrieve.ZoomedAt = 1;
						if(hit.collider.name == "middle2")
							retrieve.ZoomedAt = 2;
						if(hit.collider.name == "middle3")
							retrieve.ZoomedAt = 3;
						if(hit.collider.name == "middle4")
							retrieve.ZoomedAt = 4;
						if(hit.collider.name == "middle5")
							retrieve.ZoomedAt = 5;
						if(hit.collider.name == "middle6")
							retrieve.ZoomedAt = 6;

						//transform.position = Vector3.Lerp(transform.position,test,0.5f);
					}
				}
				else
				{
					zoomOut();
				}
			}
			else
			{
				//normal click
			}
			lastClickTime = Time.time;
		}
	}
	
	
	void zoomOut(){
		terugKnop.SetActive(true);
			retrieve.ZoomedAt = 0;
		transform.position= standardLocation;
		//blokjesContainer.transform.position = new Vector3(blokjesContainer.transform.position.x, blokjesContainer.transform.position.y - 9, blokjesContainer.transform.position.z-4);
		zoomedIn = false;
	}
}