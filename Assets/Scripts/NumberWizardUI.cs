using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizardUI : MonoBehaviour {
	
	// Use this for initialization	
	
	int max;
	int min;
	int guess;
	int mid;
	int range;
	
	public int maxguess = 8;
	
	public Text text;
	
	void Start () {
		StartGame();
	}
	
	void StartGame (){		
		max = 1000;
		min = 1;	
		NextGuess();
	}
	
	void NextGuess (){
		mid = (min+max)/2;		
		range = (max-min)/2;		
		guess = mid + Random.Range(0,range+1) - Random.Range(0,range+1);	
		text.text = guess.ToString();
		maxguess = maxguess - 1;
		if (maxguess <= 0)			{Application.LoadLevel("Win");}
	}
	
	public void GuessHigh(){
		min = guess;
		NextGuess();
	}
	
	public void GuessLower(){
		max = guess;
		NextGuess();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
