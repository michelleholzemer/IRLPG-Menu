using UnityEngine;
using System.Collections;

public class LoadWhenButtonPressed: MonoBehaviour {

	//Needs to be accessible for other objects
	//returns nothing

	
	public void LoadScene(int menuOrGame) 
	{
		Application.LoadLevel (menuOrGame); //loads the different menu scenes or the game scene
	}
}
