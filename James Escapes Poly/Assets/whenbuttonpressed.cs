using UnityEngine;
using System.Collections;

public class whenbuttonpressed : MonoBehaviour {

	public GameObject myo = null; 

	void OnGUI ()
	{
		GUI.skin.label.fontSize = 20;
		
		ThalmicHub hub = ThalmicHub.instance;
		
		// Access the ThalmicMyo script attached to the Myo object.
		ThalmicMyo thalmicMyo = myo.GetComponent<ThalmicMyo> ();
		
		if (!hub.hubInitialized) {
			GUI.Label(new Rect (12, 8, Screen.width, Screen.height),
			          "Cannot contact Myo Connect. Is Myo Connect running?\n" +
			          "Press Q to try again."
			          );
		} else if (!thalmicMyo.isPaired) {
			GUI.Label(new Rect (12, 8, Screen.width, Screen.height),
			          "No Myo currently paired."
			          );
		} else if (!thalmicMyo.armSynced) {
			GUI.Label(new Rect (12, 8, Screen.width, Screen.height),
			          "Perform the Sync Gesture."
			          );
		} else {
			GUI.Label (new Rect (12, 5, Screen.width, (Screen.height - 5)),
			           "Fist: Vibrate Myo armband\n" +
			           "Wave in: Set box material to blue\n" +
			           "Wave out: Set box material to green\n" +
			           "Double tap: Reset box material\n" +
			           "Fingers spread: Set forward direction"
			           );
		}
	}
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		ThalmicHub hub = ThalmicHub.instance;
		
		if (Input.GetKeyDown ("q")) {
			hub.ResetHub();
		}
	}
}