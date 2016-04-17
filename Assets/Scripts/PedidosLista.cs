using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PedidosLista : MonoBehaviour {
	public List<string> ListaPedidos = new List<string>(); 
	public GameObject ListaPrefab;
	public Text Nombre;
	public Text Cantidad;
	public static string Nom;
	public static string Cant;

	public void AddLista () {
	//Agregar al array Nombre + cantidad
		Nombre.text = Nom;//PlayerPrefs.GetString("Nombre");
		Cantidad.text = Cant;

		GameObject go = Instantiate(ListaPrefab) as GameObject;
		go.transform.parent = gameObject.transform;
		}


	// Update is called once per frame
	void Update () {
		
	}
}
