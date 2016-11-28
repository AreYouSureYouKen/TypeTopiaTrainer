using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class RetrieveNumbersTut : MonoBehaviour {
	public GameObject playfield;
	public GameObject playfield2;
	public GameObject playfield3;
	public GameObject playfield4;
	public GameObject playfield5;
	public GameObject playfield6;
	public Text timer;
	private GameObject blokkie1;
	private GameObject blokkie2;
	public GameObject prefabBordje;
	public GameObject platePosition;
	public GameObject holder;
	public GameObject holder2;
	public GameObject holder3;
	public GameObject holder4;
	public GameObject holder5;
	public GameObject holder6;
	public int number_of_centers = 6;
	private List<string> operators_to_use;
	private Learner learner;
	
	public int playfieldNumber;
	public int playfieldNumber2;
	public int playfieldNumber3;
	public int playfieldNumber4;
	public int playfieldNumber5;
	public int playfieldNumber6;
	public string optie;
	public string optie1;
	public string optie2;
	public string optie3;
	private string somString;
	public float timeLeft = 0f;
	int test;
	int test2;
	public PointCounter points;
	public List<string> numbersOnPlate;
	public static int numberOfPlates;
	public GameObject[] places = {null,null,null,null,null,null,null,null};
	private Vector3 Location;
	public int ZoomedAt = 0;
	
	
	void Start()
	{
		numbersOnPlate = new List<string>();
		numberOfPlates = 0;
		learner = GameObject.FindGameObjectWithTag("learner").GetComponent<Learner>();
		Dictionary<string, float> toUse = learner.getPercentagesForUse();
		int totaloperators = number_of_centers * 4;
		operators_to_use = new List<string>();
		//   print("total operators" + totaloperators);
		foreach (KeyValuePair<string, float> entry in toUse)
		{
			float times;
			int i = 0;
			switch (entry.Key)
			{
			case "+":
				times = (totaloperators * (entry.Value * 0.01f));
				for (i = 0; i < times; i++)
				{
					operators_to_use.Add("+");
				}
				break;
			case "-":
				times = (totaloperators * (entry.Value * 0.01f));
				for (i = 0; i < times; i++)
				{
					operators_to_use.Add("-");
				}
				break;
			case "x":
				times = (totaloperators * (entry.Value * 0.01f));
				for (i = 0; i < times; i++)
				{
					operators_to_use.Add("x");
				}
				break;
			case ":":
				times = (totaloperators * (entry.Value * 0.01f));
				for (i = 0; i < times; i++)
				{
					operators_to_use.Add(":");
				}
				break;
				
			default:
				break;
			}
		}
	}
	
	List<string> getOperands()
	{
		List<string> operatorsForPlayField = new List<string>();
		for (int i = 0; i < 4; i++)
		{
			int operand = Random.Range(0, (operators_to_use.Count - 1));
			operatorsForPlayField.Add(operators_to_use[operand]);
			operators_to_use.RemoveAt(operand);
		}
		return operatorsForPlayField;
	}
	
	// Update is called once per frame
	void Update () {
		List<string> operands = new List<string>();
		if (playfieldNumber == 0) {
			operands = getOperands();
			playfieldNumber = playfield.GetComponentInChildren<middlescript>().instantiation(operands);
			if(numberOfPlates < 4 ){
				foreach (string operande in operands)
				{
					//     print("passed" + operande);
					switch (operande)
					{
					case "+":
						calculateOptionsPlus(playfieldNumber);
						break;
					case "-":
						calculateOptionsMinus(playfieldNumber);
						break;
					case "x":
						calculateOptionsX(playfieldNumber);
						break;
					case ":":
						calculateOptionsDevide(playfieldNumber);
						break;
						
					default:
						break;
					}
				}
				SpawnPlate(numbersOnPlate,holder,1);
			}			
		}
		if (playfieldNumber2 == 0) {
			operands = getOperands();
			playfieldNumber2 = playfield2.GetComponentInChildren<middlescript>().instantiation(operands);
			if(numberOfPlates < 4 ){
				foreach (string operande in operands)
				{
					//                 print("passed" + operande);
					switch (operande)
					{
					case "+":
						calculateOptionsPlus(playfieldNumber2);
						break;
					case "-":
						calculateOptionsMinus(playfieldNumber2);
						break;
					case "x":
						calculateOptionsX(playfieldNumber2);
						break;
					case ":":
						calculateOptionsDevide(playfieldNumber2);
						break;
						
					default:
						break;
					}
				}
				
				
				SpawnPlate(numbersOnPlate,holder2,2);
			}
		}
		if (playfieldNumber3 == 0) {
			operands = getOperands();
			playfieldNumber3 = playfield3.GetComponentInChildren<middlescript>().instantiation(operands);
			if(numberOfPlates < 4 ){
				foreach (string operande in operands)
				{
					//        print("passed" + operande);
					switch (operande)
					{
					case "+":
						calculateOptionsPlus(playfieldNumber3);
						break;
					case "-":
						calculateOptionsMinus(playfieldNumber3);
						break;
					case "x":
						calculateOptionsX(playfieldNumber3);
						break;
					case ":":
						calculateOptionsDevide(playfieldNumber3);
						break;
						
					default:
						break;
					}
				}
				SpawnPlate(numbersOnPlate,holder3,3);
			}			
		}
		if (playfieldNumber4 == 0) {
			operands = getOperands();
			playfieldNumber4 = playfield4.GetComponentInChildren<middlescript>().instantiation(operands);
			if(numberOfPlates < 4 ){
				foreach (string operande in operands)
				{
					//              print("passed" + operande);
					switch (operande)
					{
					case "+":
						calculateOptionsPlus(playfieldNumber4);
						break;
					case "-":
						calculateOptionsMinus(playfieldNumber4);
						break;
					case "x":
						calculateOptionsX(playfieldNumber4);
						break;
					case ":":
						calculateOptionsDevide(playfieldNumber4);
						break;
						
					default:
						break;
					}
				}
				SpawnPlate(numbersOnPlate,holder4,4);
			}
		}
		if (playfieldNumber5 == 0) {
			operands = getOperands();
			playfieldNumber5 = playfield5.GetComponentInChildren<middlescript>().instantiation(operands);
			//if(numberOfPlates < 4 ){
			foreach (string operande in operands)
			{
				//                    print("passed" + operande);
				switch (operande)
				{
				case "+":
					calculateOptionsPlus(playfieldNumber5);
					break;
				case "-":
					calculateOptionsMinus(playfieldNumber5);
					break;
				case "x":
					calculateOptionsX(playfieldNumber5);
					break;
				case ":":
					calculateOptionsDevide(playfieldNumber5);
					break;
					
				default:
					break;
					//  }
				}
				
			}	SpawnPlate(numbersOnPlate,holder5,5);		
		}
		if (playfieldNumber6 == 0) {
			operands = getOperands();
			playfieldNumber6 = playfield6.GetComponentInChildren<middlescript>().instantiation(operands);
			if(numberOfPlates < 4 ){
				foreach (string operande in operands)
				{
					//                    print("passed" + operande);
					switch (operande)
					{
					case "+":
						calculateOptionsPlus(playfieldNumber6);
						break;
					case "-":
						calculateOptionsMinus(playfieldNumber6);
						break;
					case "x":
						calculateOptionsX(playfieldNumber6);
						break;
					case ":":
						calculateOptionsDevide(playfieldNumber6);
						break;
						
					default:
						break;
					}
				}
				SpawnPlate(numbersOnPlate,holder6,6);
			}
		}
		else if(!points.finished)
		{
			timeLeft += Time.deltaTime;
			timer.text = "Time: " + (int)timeLeft;
		}
		else 
		{
			GameOver();
		}
		if(numbersOnPlate == null)
		{
			numbersOnPlate = new List<string>();
		}
		if(ZoomedAt == 0)
		{
			holder.SetActive(false);
			holder2.SetActive(false);
			holder3.SetActive(false);
			holder4.SetActive(false);
			holder5.SetActive(false);
			holder6.SetActive(false);
			
			
		}
		if(ZoomedAt == 1)
		{
			holder.SetActive(true);
			
		}
		if(ZoomedAt == 2)
		{
			holder2.SetActive(true);
			
		}
		if(ZoomedAt == 3)
		{
			holder3.SetActive(true);
			
		}
		if(ZoomedAt == 4)
		{
			holder4.SetActive(true);
			
		}
		if(ZoomedAt == 5)
		{
			holder5.SetActive(true);
			
		}
		if(ZoomedAt == 6)
		{
			holder6.SetActive(true);
			
		}
		
		
		
	}
	private void GameOver(){
		//		Debug.Log("Gameover");
		//Time.timeScale = 0;
		numberOfPlates = 0;
		numbersOnPlate = null;
		
	}
	private void calculateOptionsMinus(int number){
		
		int random1 = Random.Range (0, 20);
		int random2 = number + random1;
		
		createBordje (random1, random2, 1);
	}
	private void calculateOptionsPlus(int number){
		
		int random1 = Random.Range (0, number);			
		int random2 = number - random1;			
		createBordje (random2, random1,2);
		
	}
	
	private void calculateOptionsX(int number){
		
		test = Random.Range (1, 20);
		int random2;
		for (int i=0; i<100; i++) {
			if(number % test != 0)test = Random.Range (1, 20);
			if(number % test == 0){
				
				random2 = number / test;
				createBordje (test, random2, 3);
				return;
			}
			
		}
		
		
	}
	private void calculateOptionsDevide(int number){
		
		test2 = Random.Range (1, 20);
		int random2;
		for (int i=0; i<100; i++) {
			if(number % test2 != 0)test2 = Random.Range (1, 20);
			if(number % test2 == 0){
				
				random2 = number * test2;
				createBordje (test2, random2, 4);
				return;
			}
			
		}
	}
	
	public void createBordje(int option1, int option2, int som){
		if(som ==1){		
			somString = option2 + "-" + option1;
			AddToList(somString);
			optie = option2.ToString () + "-" + option1.ToString () + "=" + playfieldNumber.ToString();
		}
		else if(som == 2){
			somString = option2 + "-" + option1;
			AddToList(somString);
			optie1 = option2.ToString () + "+" + option1.ToString () + "=" + playfieldNumber.ToString();
		}
		else if(som == 3){
			somString = option2 + "-" + option1;
			AddToList(somString);
			optie2 = option2.ToString () + "X" + option1.ToString () + "=" + playfieldNumber.ToString();
		}
		else if(som == 4){
			somString = option2 + "-" + option1;
			AddToList(somString);
			optie3 = option2.ToString () + "/" + option1.ToString () + "=" + playfieldNumber.ToString();
		}
		
		
	}
	public void AddToList(string number){
		
		numbersOnPlate.Add(number);
	}
	public void SpawnPlate(List<string> numbers, GameObject container, int containerNr){
		
		/*
		 *pak  (playfieldNr-1) * 4
		 *forloop vorigbordje +1
		 *
		 */
		//int randomNumber = Random.Range(0,numbers.Count);
		
		for(int i=0;i<8;i++){
			places[i]=null;
		}
		Debug.Log(containerNr);
		int pakblokje = 4*(containerNr-1);
		for(int i =0; i<4; i++){
			string randomstring = numbers[pakblokje];
			string[] string1 = randomstring.Split("-"[0]);
			int number1 = int.Parse(string1[0]);
			int number2 = int.Parse(string1[1]);
			blokkie1 = (GameObject)Instantiate(prefabBordje,searchPlace(container), platePosition.transform.rotation);
			blokkie1.transform.parent=container.transform;
			//platePosition.transform.position+= transform.right*3;
			insertInArray(blokkie1);
			blokkie2 = (GameObject)Instantiate(prefabBordje,searchPlace(container), platePosition.transform.rotation);
			blokkie2.transform.parent=container.transform;
			//platePosition.transform.position+= transform.right*3;
			insertInArray(blokkie2);
			blokkie1.GetComponent<textchanger>().number = number1;
			blokkie2.GetComponent<textchanger>().number = number2;
			//numbersOnPlate.Remove(numbers[randomNumber]);
			pakblokje++;
			//numberOfPlates+=2;
		}
	}
	public Vector3 searchPlace(GameObject container){
		Vector3 newplace = container.transform.position;
		if(places[0]==null){
			newplace += new Vector3(4.5f,-.6f,1f);
			//			places[0] = true;
		}
		else if(places[1]==null){
			newplace += new Vector3(2.5f,-0.6f,1f);
			//places[1] = true;
		}
		else if(places[2]==null){
			newplace += new Vector3(0.5f,-0.6f,1f);
			//			places[2] = true;
		}
		else if(places[3]==null){
			newplace += new Vector3(3.5f,-0.6f,-0.2f);
			//		places[3] = true;
		}
		else if(places[4]==null){
			newplace += new Vector3(1.5f,-0.6f,-0.2f);
			//		places[4] = true;
		}
		else if(places[5]==null){
			newplace += new Vector3(4.5f,-0.6f,-1.4f);
			//		places[5] = true;
		}
		else if(places[6]==null){
			newplace += new Vector3(2.5f,-0.6f,-1.4f);
			//		places[6] = true;
		}
		else if(places[7]==null){
			newplace += new Vector3(0.5f,-0.6f,-1.4f);
			//		places[7] = true;
		}
		
		return newplace;
	}
	
	void insertInArray(GameObject blokje)
	{
		for(int i =0; i<8; i++)
		{
			if(places[i] == null)
			{
				places[i] = blokje;
				return;
			}
		}
	}
}
