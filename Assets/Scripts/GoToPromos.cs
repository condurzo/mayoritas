using UnityEngine;
using System.Collections;

public class GoToPromos : MonoBehaviour {
	public GameObject SeccionHome;
	public GameObject SeccionPrecios;
	public GameObject SeccionArmarPedidos;
	public GameObject SeccionListaPedido;

	public void IrPromos () {
		Application.LoadLevel ("Book");
	}
	
	void Start () {
		int TempSeccion = PlayerPrefs.GetInt ("Estado");
		switch (TempSeccion) {
		case 0:
			SeccionHome.SetActive (true);
			break;
		case 1:
			SeccionPrecios.SetActive (true);
			break;
		case 2:
			SeccionArmarPedidos.SetActive (true);
			break;
		case 3:
			SeccionListaPedido.SetActive (true);
			break;
		}
	}
}
