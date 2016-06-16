using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class MenuBtn : MonoBehaviour {
	public GameObject MenuGO;
	public bool states;
	public GameObject[] BotonesMenu;
	public GameObject SalirCartel;

	public void OpenMenu () {
			iTween.MoveTo (MenuGO, iTween.Hash ("x", 68, "time", .4, "loopType", "none"
			, "delay", 0, "easeType", "easeInOutQuad"));
		
	}
	public void CloseMenu(){
			iTween.MoveTo (MenuGO, iTween.Hash ("x", -120, "time", .4, "loopType", "none"
				, "delay", 0, "easeType", "easeInOutQuad"));
		
	}

	public void CancelarTodos(){
		BotonesMenu [0].SetActive (false);
		BotonesMenu [1].SetActive (false);
		BotonesMenu [2].SetActive (false);
		BotonesMenu [3].SetActive (false);
		BotonesMenu [4].SetActive (false);
		BotonesMenu [5].SetActive (false);
		BotonesMenu [6].SetActive (false);
		BotonesMenu [7].SetActive (false);
		BotonesMenu [8].SetActive (false);
		BotonesMenu [9].SetActive (false);
		BotonesMenu [10].SetActive (false);
		BotonesMenu [11].SetActive (false);
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SalirCartel.SetActive (true);
		}
	}

	public void ExitApp(){
		Application.Quit ();
	}

}
