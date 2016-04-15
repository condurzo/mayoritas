using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PedidosLista : MonoBehaviour {
	public List<string> ListaPedidos = new List<string>(); 
	public GameObject ListaPrefab;
	public Text Nombre;
	public Text Cantidad;

	public void AddLista () {
	//Agregar al array Nombre + cantidad
		Nombre.text = PlayerPrefs.GetString("Nombre");
		Cantidad.text = PlayerPrefs.GetString ("Cantidad");

		ListaPedidos.Add(PlayerPrefs.GetString("Cantidad"));
		ListaPedidos.Add(PlayerPrefs.GetString("Nombre"));
		GameObject go = Instantiate(ListaPrefab) as GameObject;
		go.transform.parent = gameObject.transform;
		}


	// Update is called once per frame
	void Update () {
	
	}
}
