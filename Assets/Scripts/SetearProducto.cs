using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetearProducto : MonoBehaviour {

	public static string NombreProducto;
	public static bool UsarNombre;
	public Text Nombre;
	public GameObject PopupSearch;

	void Start(){
		PopupSearch = GameObject.Find ("PopupBuscar");
	}

	public void ObtenerNombre(){
		NombreProducto = Nombre.text;
		UsarNombre = true;
		PopupSearch.SetActive (false);
	}
}
