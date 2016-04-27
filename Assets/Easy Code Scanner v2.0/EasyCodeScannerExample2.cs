using UnityEngine;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;
using UnityEngine.UI;
public class EasyCodeScannerExample2 : MonoBehaviour {
	
	static string dataStr;
	//public Renderer PlaneRender;
	public Text nombreProducto;
	public Text descripcionProducto;
	public Text precio;
	public Image ImagenProducto;
	public Sprite[] productos;

	void Start () {
		dataStr = "";
		
		// Initialize EasyCodeScanner
		EasyCodeScanner.Initialize();
		
		//Register on Actions
		EasyCodeScanner.OnScannerMessage += onScannerMessage;
		EasyCodeScanner.OnScannerEvent += onScannerEvent;
		EasyCodeScanner.OnDecoderMessage += onDecoderMessage;
		
		//Screen.orientation = ScreenOrientation.LandscapeLeft;
	}
	
	void OnDestroy() {
		
		//Unregister
		EasyCodeScanner.OnScannerMessage -= onScannerMessage;
		EasyCodeScanner.OnScannerEvent -= onScannerEvent;
		EasyCodeScanner.OnDecoderMessage -= onDecoderMessage;
	}
	
	public void Update() {
			
//		if (Input.GetKeyDown(KeyCode.Escape)) { 
//			Application.Quit();
//		}
	
		if (SetearProducto.UsarNombre) {
			switch (SetearProducto.NombreProducto) {
			case "Ayudin 1Lt":
				nombreProducto.text = "Lavandina Ayudin";
				descripcionProducto.text = "Maxima Pureza - 1 Litro";
				precio.text = "16,00";
				ImagenProducto.sprite = productos [3];
				PedidosLista.Nom = nombreProducto.text;
				PedidosLista.Pre = precio.text;
				PedidosLista.Desc = descripcionProducto.text;
				break;
			
			case "Ayudin 2Lt":
			nombreProducto.text = "Lavandina Ayudin";
			descripcionProducto.text = "Maxima Pureza - 2 Litros";
			precio.text = "16,00";
			ImagenProducto.sprite = productos [4];
			PedidosLista.Nom = nombreProducto.text;
			PedidosLista.Pre = precio.text;
			PedidosLista.Desc = descripcionProducto.text;
			break;

			case "Ayudin Gla 1Lt":
				nombreProducto.text = "Lavandina Ayudin";
				descripcionProducto.text = "Pureza del Galciar - 1 Litro";
				precio.text = "16,00";
				ImagenProducto.sprite = productos [5];
				PedidosLista.Nom = nombreProducto.text;
				PedidosLista.Pre = precio.text;
				PedidosLista.Desc = descripcionProducto.text;
				break;

			case "Ayudin Multi 4Lt":
				nombreProducto.text = "Lavandina Ayudin";
				descripcionProducto.text = "MultiSuperficies - 4 Litros";
				precio.text = "16,00";
				ImagenProducto.sprite = productos [6];
				PedidosLista.Nom = nombreProducto.text;
				PedidosLista.Pre = precio.text;
				PedidosLista.Desc = descripcionProducto.text;
				break;
			case "Querubin Lav 1Lt":
				nombreProducto.text = "Lavandina Querubin";
				descripcionProducto.text = "Lavanda - 1 Litro";
				precio.text = "16,00";
				ImagenProducto.sprite = productos [7];
				PedidosLista.Nom = nombreProducto.text;
				PedidosLista.Pre = precio.text;
				PedidosLista.Desc = descripcionProducto.text;
				break;
			case "Querubin Pre 1Lt":
				nombreProducto.text = "Lavandina Querubin";
				descripcionProducto.text = "Premium - 1 Litro";
				precio.text = "16,00";
				ImagenProducto.sprite = productos [8];
				PedidosLista.Nom = nombreProducto.text;
				PedidosLista.Pre = precio.text;
				PedidosLista.Desc = descripcionProducto.text;
				break;
			case "Querubin Pre 4Lt":
				nombreProducto.text = "Lavandina Querubin";
				descripcionProducto.text = "Premium - 4 Litros";
				precio.text = "16,00";
				ImagenProducto.sprite = productos [9];
				PedidosLista.Nom = nombreProducto.text;
				PedidosLista.Pre = precio.text;
				PedidosLista.Desc = descripcionProducto.text;
				break;
			
		}

		} else {
			switch (dataStr) {
			case "7792378000562":
				nombreProducto.text = "Gel de Alcohol Etilico Neutro MF";
				descripcionProducto.text = "250cc";
				precio.text = "16,00";
				ImagenProducto.sprite = productos [1];
				PedidosLista.Nom = nombreProducto.text;
				PedidosLista.Pre = precio.text;
				PedidosLista.Desc = descripcionProducto.text;
				break;
			case "7790250054276":
				nombreProducto.text = "Elite Doble Hoja";
				descripcionProducto.text = "100 Pañuelos - 22cmx21cm";
				precio.text = "27,50";
				ImagenProducto.sprite = productos [2];
				PedidosLista.Nom = nombreProducto.text;
				PedidosLista.Pre = precio.text;
				PedidosLista.Desc = descripcionProducto.text;
				break;
			}
		}
	}

	public void ShowCam(){
		SetearProducto.UsarNombre = false;

		EasyCodeScanner.launchScanner( true, "", -1, true);
	}

	public void Limpiar(){
		nombreProducto.text = "Nombre";
		descripcionProducto.text = "Descripcion";
		precio.text = "Precio";
		ImagenProducto.sprite = productos[0];
	}


//	void OnGUI ()
//	{
//		//--- To be replaced by your controls, just to showcase ---
//		if (GUI.Button(new Rect (10, 125, 300, 100), "Launch scanner"))
//		{
//			//for code list, see : http://zbar.sourceforge.net/api/zbar_8h.html#f7818ad6458f9f40362eecda97acdcb0
//			// and zbar.h 
//			/*
//			typedef enum zbar_symbol_type_e {
//		    ZBAR_NONE        =      0,  < no symbol decoded 
//		    ZBAR_PARTIAL     =      1,  < intermediate status 
//		    ZBAR_EAN8        =      8,  < EAN-8 /
//		    ZBAR_UPCE        =      9,  < UPC-E 
//		    ZBAR_ISBN10      =     10,  < ISBN-10 (from EAN-13). @since 0.4 
//		    ZBAR_UPCA        =     12,  < UPC-A 
//		    ZBAR_EAN13       =     13,  < EAN-13 
//		    ZBAR_ISBN13      =     14,  < ISBN-13 (from EAN-13). @since 0.4 
//		    ZBAR_I25         =     25,  < Interleaved 2 of 5. @since 0.4 
//		    ZBAR_CODE39      =     39,  < Code 39. @since 0.4 
//		    ZBAR_PDF417      =     57,  < PDF417. @since 0.6 
//		    ZBAR_QRCODE      =     64,  < QR Code. @since 0.10 
//		    ZBAR_CODE128     =    128,  < Code 128 
//		    ZBAR_SYMBOL      = 0x00ff,  < mask for base symbol type 
//		    ZBAR_ADDON2      = 0x0200,  < 2-digit add-on flag 
//		    ZBAR_ADDON5      = 0x0500,  < 5-digit add-on flag 
//		    ZBAR_ADDON       = 0x0700,  < add-on flag mask 
//			} zbar_symbol_type_t;
//			*/
//			//for instance, only QRCodes
//			//launchScanner( true, "Scanning...", 64, true);
//			
//			//all codes at the same time : value = -1
//			EasyCodeScanner.launchScanner( true, "Scanning...", -1, true);
//		}
//	
//		dataStr = GUI.TextArea(new Rect (10, 275, 300, 100), dataStr);
//		//---
//	}
	
	//Callback when returns from the scanner
	void onScannerMessage(string data){
		Debug.Log("EasyCodeScannerExample - onScannerMessage data=:"+data);
		dataStr = data;
		
		//Just to show case : get the image and display it on a Plane
		//Texture2D tex = EasyCodeScanner.getScannerImage(200, 200);
		//PlaneRender.material.mainTexture = tex;
		
		//Just to show case : decode a texture/image - refer to code list
		//EasyCodeScanner.decodeImage(-1, tex);
	}
	
	//Callback which notifies an event
	//param : "EVENT_OPENED", "EVENT_CLOSED"
	void onScannerEvent(string eventStr){
		Debug.Log("EasyCodeScannerExample - onScannerEvent:"+eventStr);
	}
	
	//Callback when decodeImage has decoded the image/texture 
	void onDecoderMessage(string data){
		Debug.Log("EasyCodeScannerExample - onDecoderMessage data:"+data);
		dataStr = data;
	}
	
	
	
}