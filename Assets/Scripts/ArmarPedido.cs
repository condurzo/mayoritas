using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ArmarPedido : MonoBehaviour {
	public Text Nombre;
	public Button OkBtn;
	public InputField Cantidad;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		PedidosLista.Cant = Cantidad.text;

		if ((Nombre.text == "Nombre")||(Cantidad.text == "")) {
			OkBtn.interactable = false;
			OkBtn.GetComponent<Image> ().color = Color.red;
		} else {
			OkBtn.interactable = true;
			OkBtn.GetComponent<Image> ().color = Color.green;
		}
	}
}
