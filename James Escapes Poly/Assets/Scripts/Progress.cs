using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Progress : MonoBehaviour {

	public Slider slider;
	// Update is called once per frame
	void Update () {
		Debug.Log (slider.value);
		slider.value = Mathf.MoveTowards (slider.value, 10.0f, 1.0f);
	}
}
