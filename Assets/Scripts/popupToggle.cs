using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popupToggle : MonoBehaviour {
	
	int counter = 0;
	public GameObject Panel;
	void Start () {
		Panel.gameObject.SetActive(false);
	}
	public void togglePanel()
	{
		counter++;
		if (counter % 2== 1){
			Panel.gameObject.SetActive(true);
		}
		else if (counter % 2== 0){
			Panel.gameObject.SetActive(false);
		}
		
	}
	
}

	


