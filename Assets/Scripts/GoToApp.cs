using UnityEngine;
using System.Collections;

public class GoToApp : MonoBehaviour {

	public void SeccionPrecios () {
		PlayerPrefs.SetInt ("Estado", 1);
		Application.LoadLevel ("Home");
	}
	public void SeccionArmarPedido () {
		PlayerPrefs.SetInt ("Estado", 2);
		Application.LoadLevel ("Home");
	}
	public void SeccionListaPedido () {
		PlayerPrefs.SetInt ("Estado", 3);
		Application.LoadLevel ("Home");
	}
	public void SeccionHome () {
		PlayerPrefs.SetInt ("Estado", 0);
		Application.LoadLevel ("Home");
	}

}
