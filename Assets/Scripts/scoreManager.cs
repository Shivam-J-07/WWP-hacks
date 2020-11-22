using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour {

	public Text score;

	private int scoreAmount = 0;

	public GameObject waterToggle;

	public GameObject distanceToggle;

	public GameObject meditationToggle;

	public GameObject eatingToggle;

	private bool waterToggleBool = false;

	private bool distanceToggleBool = false;

	private bool meditationToggleBool = false;

	private bool eatingToggleBool = false;

	void Update () {
		if (waterToggle.GetComponent<Toggle>().isOn == true && waterToggleBool == false)
		{
			waterToggleBool = true;

			scoreAmount = scoreAmount + 200;

			score.text = scoreAmount.ToString();
		}

		if (distanceToggle.GetComponent<Toggle>().isOn == true && distanceToggleBool == false)
		{
			distanceToggleBool = true;

			scoreAmount = scoreAmount + 200;

			score.text = scoreAmount.ToString();
		}

		if (meditationToggle.GetComponent<Toggle>().isOn == true && meditationToggleBool == false)
		{
			meditationToggleBool = true;

			scoreAmount = scoreAmount + 200;

			score.text = scoreAmount.ToString();
		}

		if (eatingToggle.GetComponent<Toggle>().isOn == true && eatingToggleBool == false)
		{
			eatingToggleBool = true;

			scoreAmount = scoreAmount + 200;

			score.text = scoreAmount.ToString();
		}
	
	}
}
