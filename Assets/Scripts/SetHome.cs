using UnityEngine;
using System.Collections;

public class SetHome : MonoBehaviour {
	public float Contador;
	void Start () {
		PlayerPrefs.SetInt ("Estado", 0);
	}

	void Update(){
		Contador += Time.deltaTime;
		if (Contador >= 2.5f) {
			Application.LoadLevel ("SplashE");
		}
	}
	

}
