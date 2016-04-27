using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PedidosLista : MonoBehaviour {
	public List<string> ListaPedidos = new List<string>(); 
	public GameObject ListaPrefab;
	public Text Nombre;
	public Text Descripcion;
	public Text Cantidad;
	public Text Precio;
	public static string Nom;
	public static string Desc;
	public static string Cant;
	public static string Pre;

	public void AddLista () {
	//Agregar al array Nombre + cantidad
		Nombre.text = Nom;//PlayerPrefs.GetString("Nombre");
		Precio.text = Pre;
		Cantidad.text = Cant;
		Descripcion.text = Desc;

		GameObject go = Instantiate(ListaPrefab) as GameObject;
		go.transform.parent = gameObject.transform;
		}


	public void EnviarBtn () {
		Application.LoadLevel ("Home");
	}
}
