using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dietButtonManager : MonoBehaviour {

	public Button MonThurs;

	public Button TuesFri;

	public Button WedSat;

	public Button Sun;

	public void disableButtonMonThurs(){
		MonThurs.interactable = false;
	}

	public void disableButtonTuesFri(){
		TuesFri.interactable = false;
	}

	public void disableButtonWedSat(){
		WedSat.interactable = false;
	}

	public void disableButtonSun(){
		Sun.interactable = false;
	}
}
