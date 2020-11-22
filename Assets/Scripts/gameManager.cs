using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {

	public void toInstructions(){
		SceneManager.LoadScene("Instructions");
	}

	public void toInfoPage1(){
		SceneManager.LoadScene("infoPage1");
	}

	public void toInfoPage2(){
		SceneManager.LoadScene("infoPage2");
	}

	public void toResults(){
		SceneManager.LoadScene("Results");
	}

	public void toChecklist(){
		SceneManager.LoadScene("Checklist");
	}

	public void toFunFacts(){
		SceneManager.LoadScene("Fun Facts");
	}

	public void toOverview(){
		SceneManager.LoadScene("Overview");
	}

	public void toStart(){
		SceneManager.LoadScene("Start page");
	}

	public void toLastPage(){
		SceneManager.LoadScene("Final page");
	}

}
