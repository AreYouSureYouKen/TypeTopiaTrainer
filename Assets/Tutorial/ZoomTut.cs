using UnityEngine;

public class ZoomTut : MonoBehaviour
{
	public float perspectiveZoomSpeed = 0.5f;        // The rate of change of the field of view in perspective mode.
	public float orthoZoomSpeed = 0.5f;        // The rate of change of the orthographic size in orthographic mode.
	public bool zoomedIn = true;
	public float speed = 0.1F;
	private float lastClickTime;
	private float catchTime = 0.25f;
	private Vector3 standardLocation;
	public bool zoomingEnabled = false;	
	public GameObject GM;
	
	
	
	void Start(){
		standardLocation = this.transform.position+ new Vector3(0,9,0);
	}
	
	void Update()
	{
		if (zoomingEnabled) {
						if (Input.GetButtonDown ("Fire1")) {
								if (Time.time - lastClickTime < catchTime) {
										//double click
										if (!zoomedIn) {

												zoomedIn = true;
												//terugKnop.SetActive(false);
												GM.GetComponent<TutManager> ().zoomComplete = true;
												//blokjesContainer.transform.position = new Vector3(blokjesContainer.transform.position.x, blokjesContainer.transform.position.y + 9, blokjesContainer.transform.position.z + 4);
												transform.position = this.transform.position - new Vector3 (0, 9, 0);
					
						
						
												//transform.position = Vector3.Lerp(transform.position,test,0.5f);

										} else {
												zoomOut ();
										}
								} else {
										//normal click
								}
								lastClickTime = Time.time;
						}
				}
	}
	
	
	void zoomOut(){
		//terugKnop.SetActive(true);
		//retrieve.ZoomedAt = 0;
		transform.position= standardLocation ;

		//blokjesContainer.transform.position = new Vector3(blokjesContainer.transform.position.x, blokjesContainer.transform.position.y - 9, blokjesContainer.transform.position.z-4);
		zoomedIn = false;
	}
}