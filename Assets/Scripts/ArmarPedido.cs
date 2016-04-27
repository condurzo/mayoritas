using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ArmarPedido : MonoBehaviour {
	public Text Nombre;
	public Button OkBtn;
	public InputField Cantidad;
	public Button MasBtn;
	public Button MenosBtn;
	public int CantidadProducto;
	public int TempCantidad;

	void Start () {
		Cantidad.keyboardType = TouchScreenKeyboardType.NumberPad;
		Cantidad.text = "0";
	}
	
	void Update () {
		
		CantidadProducto = System.Int32.Parse(Cantidad.text);
		PedidosLista.Cant = Cantidad.text;

//		if (Cantidad.wasCanceled) {
//			Cantidad.text = CantidadProducto.ToString ();
//		} else {
//			
//		}

		if ((Nombre.text == "Nombre")||(Cantidad.text == "")) {
			OkBtn.interactable = false;
			OkBtn.GetComponent<Image> ().color = Color.red;
		} else {
			OkBtn.interactable = true;
			OkBtn.GetComponent<Image> ().color = Color.green;
		}
		if (TempCantidad <= 0) {
			TempCantidad = 0;
		}
		if (CantidadProducto <= 0) {
			CantidadProducto = 0;
		}
	}
	public void Sumar(){
		TempCantidad = CantidadProducto + 1;
		Cantidad.text = TempCantidad.ToString();
	}
	public void Restar(){
		if (CantidadProducto > 0) {
			TempCantidad = CantidadProducto - 1;
			Cantidad.text = TempCantidad.ToString ();
		}
	}
}
