using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TutManager : MonoBehaviour {

	// Use this for initialization
	public Text textPanel;
	public Button continueBt;
	public GameObject player;
	public int stage = 0;
	public GameObject finish;
	public GameObject blokjes;
	public GameObject firstblokjes;
	public GameObject arrow;
	public GameObject arrowSmall;
	public GameObject arrowSmall2;
	public GameObject zoomscript;
	public bool firstComplete = false;
	public bool padComplete = false;
	public bool zoomComplete = false;

	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (stage == 1) {
						textPanel.text = "Maak nu de eerste som: 10 = ? - ? Dit kun je doen door de blokjes te slepen naar de juiste locatie. Als de blokjes groen worden is de som goed.";
						arrow.SetActive (false);
						firstblokjes.SetActive (true);
						arrowSmall.SetActive (true);
						arrowSmall2.SetActive (true);
						continueBt.interactable = false;
						if (firstComplete) {
								continueBt.interactable = true;
								arrowSmall.SetActive (false);
								arrowSmall2.SetActive (false);
								textPanel.text = "Goed zo! Het eerste deel van het pad is nu opgelost. De som wordt nu ook groen en dat " +
										"betekend dat je de blokjes niet meer mag verplaatsen.";
						}
				} else if (stage == 2) {
						textPanel.text = "Het wordt nu een beetje moeilijker. Je hebt een paar blokjes meer. Probeer het nu eens om het pad naar de finish op te lossen!";
						blokjes.SetActive (true);
						continueBt.interactable = false;
						if (padComplete) {
								textPanel.text = "Het pad is nu vrijgespeeld en het mannetje gaat nu lopen! Wil je nog meer punten halen los dan de andere sommen ook op.";
								continueBt.interactable = true;


						}
			
				} else if (stage == 3) {
						textPanel.text = "Je kunt ook in/uitzoomen door 2x op een puzzel ster te klikken. Probeer dat eens! ";
						zoomscript.GetComponent<ZoomTut> ().zoomingEnabled = true;
					continueBt.interactable = false;
						if (zoomComplete) {
								textPanel.text = "Gefeliciteerd je bent nu klaar met de tutorial, speel nu een echte game en behaal een highscore. Succes met rekenen!";
								continueBt.GetComponentInChildren<Text> ().text = "Speel Nu!";
								continueBt.interactable = true;
						}
				} else if (stage == 4) {
			Application.LoadLevel("generator");
					Debug.Log("Start echt game hier");

				}
	
	}
	public void UpdateStage(){
		Debug.Log("Button was pressed");
		stage++;

	}
}
