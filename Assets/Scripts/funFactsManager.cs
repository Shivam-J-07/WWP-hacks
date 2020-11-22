using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class funFactsManager : MonoBehaviour {

	int counter = 0;

	public Text funFact ;

	public void updateFunFact(){

		counter++;

		if (counter % 2 == 1){
			funFact.text = "Fun Fact #2: Exercising increases the number of endorphins that are released into your body and increases productivity";
		} else{
			funFact.text = "Fun Fact #1: Laughing is good for the heart and can increase blood flow by 20%";
		}
	}

}
