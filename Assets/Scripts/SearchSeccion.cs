using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class SearchSeccion : MonoBehaviour {
	public InputField Buscador;
	public string Busqueda;
	public string[] BusquedaArray;
	public Text Nombre;
	public List<string> ListaProductos = new List<string> ();
	public GameObject CruciPrefab;
	public GameObject[]ScrollProductos;
	public bool DesactivarTemp;


	void Start () {
		Busqueda = BusquedaArray[0];
	}


	public void Buscar () {
//		foreach (string Buscado in BusquedaArray) {
//			Busqueda = Buscado;
//			Debug.Log ("Buscado: " + Buscado);
//		}
		if (DesactivarTemp) {
			Debug.Log ("LALA");
			ScrollProductos = GameObject.FindGameObjectsWithTag ("Productos");
			for (int i = 0; i < ScrollProductos.Length; i++) {
				ScrollProductos [i].SetActive (false);
			}
			DesactivarTemp = false;
		}


		if(Busqueda.IndexOf(Buscador.text, System.StringComparison.CurrentCultureIgnoreCase) >0){
			for (int i = 0; i < ListaProductos.Count; i++) {
				GameObject go = Instantiate(CruciPrefab) as GameObject;
				go.transform.parent = gameObject.transform;
				Nombre.text = ListaProductos [i];
			}
			DesactivarTemp = true;
		} else {
			Debug.Log("String not found");
		}

	}
}
