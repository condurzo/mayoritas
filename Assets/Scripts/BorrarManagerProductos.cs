using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BorrarManagerProductos : MonoBehaviour {

	//Imagen Grande
	public Text Precio;
	public Text PrecioIva;
	public Text Nombre;
	public Text Descripcion;
	public Image ImagenProducto;

	public GameObject Oferta;

	//Home
	public Text Home1Text1;
	public Text Home1Text2;
	public Text Home1Text3;
	public Sprite Home1Imagen;
	public Text Home2Text1;
	public Text Home2Text2;
	public Text Home2Text3;
	public Sprite Home2Imagen;
	public Text Home3Text1;
	public Text Home3Text2;
	public Text Home3Text3;
	public Sprite Home3Imagen;
	public Text Home4Text1;
	public Text Home4Text2;
	public Text Home4Text3;
	public Sprite Home4Imagen;
	public Text Home5Text1;
	public Text Home5Text2;
	public Text Home5Text3;
	public Sprite Home5Imagen;


	//Almacen
	public Text Almacen1Text1;
	public Text Almacen1Text2;
	public Text Almacen1Text3;
	public Sprite Almacen1Imagen;
	public Text Almacen2Text1;
	public Text Almacen2Text2;
	public Text Almacen2Text3;
	public Sprite Almacen2Imagen;
	public Text Almacen3Text1;
	public Text Almacen3Text2;
	public Text Almacen3Text3;
	public Sprite Almacen3Imagen;
	public Text Almacen4Text1;
	public Text Almacen4Text2;
	public Text Almacen4Text3;
	public Sprite Almacen4Imagen;
	public Text Almacen5Text1;
	public Text Almacen5Text2;
	public Text Almacen5Text3;
	public Sprite Almacen5Imagen;

	//Galletitas
	public Text Galletitas1Text1;
	public Text Galletitas1Text2;
	public Text Galletitas1Text3;
	public Sprite Galletitas1Imagen;
	public Text Galletitas2Text1;
	public Text Galletitas2Text2;
	public Text Galletitas2Text3;
	public Sprite Galletitas2Imagen;
	public Text Galletitas3Text1;
	public Text Galletitas3Text2;
	public Text Galletitas3Text3;
	public Sprite Galletitas3Imagen;
	public Text Galletitas4Text1;
	public Text Galletitas4Text2;
	public Text Galletitas4Text3;
	public Sprite Galletitas4Imagen;
	public Text Galletitas5Text1;
	public Text Galletitas5Text2;
	public Text Galletitas5Text3;
	public Sprite Galletitas5Imagen;

	//Kiosco
	public Text Kiosco1Text1;
	public Text Kiosco1Text2;
	public Text Kiosco1Text3;
	public Sprite Kiosco1Imagen;
	public Text Kiosco2Text1;
	public Text Kiosco2Text2;
	public Text Kiosco2Text3;
	public Sprite Kiosco2Imagen;
	public Text Kiosco3Text1;
	public Text Kiosco3Text2;
	public Text Kiosco3Text3;
	public Sprite Kiosco3Imagen;
	public Text Kiosco4Text1;
	public Text Kiosco4Text2;
	public Text Kiosco4Text3;
	public Sprite Kiosco4Imagen;
	public Text Kiosco5Text1;
	public Text Kiosco5Text2;
	public Text Kiosco5Text3;
	public Sprite Kiosco5Imagen;

	//Mascotas
	public Text Mascotas1Text1;
	public Text Mascotas1Text2;
	public Text Mascotas1Text3;
	public Sprite Mascotas1Imagen;
	public Text Mascotas2Text1;
	public Text Mascotas2Text2;
	public Text Mascotas2Text3;
	public Sprite Mascotas2Imagen;
	public Text Mascotas3Text1;
	public Text Mascotas3Text2;
	public Text Mascotas3Text3;
	public Sprite Mascotas3Imagen;
	public Text Mascotas4Text1;
	public Text Mascotas4Text2;
	public Text Mascotas4Text3;
	public Sprite Mascotas4Imagen;
	public Text Mascotas5Text1;
	public Text Mascotas5Text2;
	public Text Mascotas5Text3;
	public Sprite Mascotas5Imagen;


	//Bebidas
	public Text Bebidas1Text1;
	public Text Bebidas1Text2;
	public Text Bebidas1Text3;
	public Sprite Bebidas1Imagen;
	public Text Bebidas2Text1;
	public Text Bebidas2Text2;
	public Text Bebidas2Text3;
	public Sprite Bebidas2Imagen;
	public Text Bebidas3Text1;
	public Text Bebidas3Text2;
	public Text Bebidas3Text3;
	public Sprite Bebidas3Imagen;
	public Text Bebidas4Text1;
	public Text Bebidas4Text2;
	public Text Bebidas4Text3;
	public Sprite Bebidas4Imagen;
	public Text Bebidas5Text1;
	public Text Bebidas5Text2;
	public Text Bebidas5Text3;
	public Sprite Bebidas5Imagen;


	//Bodega
	public Text Bodega1Text1;
	public Text Bodega1Text2;
	public Text Bodega1Text3;
	public Sprite Bodega1Imagen;
	public Text Bodega2Text1;
	public Text Bodega2Text2;
	public Text Bodega2Text3;
	public Sprite Bodega2Imagen;
	public Text Bodega3Text1;
	public Text Bodega3Text2;
	public Text Bodega3Text3;
	public Sprite Bodega3Imagen;
	public Text Bodega4Text1;
	public Text Bodega4Text2;
	public Text Bodega4Text3;
	public Sprite Bodega4Imagen;
	public Text Bodega5Text1;
	public Text Bodega5Text2;
	public Text Bodega5Text3;
	public Sprite Bodega5Imagen;


	//Limpieza
	public Text Limpieza1Text1;
	public Text Limpieza1Text2;
	public Text Limpieza1Text3;
	public Sprite Limpieza1Imagen;
	public Text Limpieza2Text1;
	public Text Limpieza2Text2;
	public Text Limpieza2Text3;
	public Sprite Limpieza2Imagen;
	public Text Limpieza3Text1;
	public Text Limpieza3Text2;
	public Text Limpieza3Text3;
	public Sprite Limpieza3Imagen;
	public Text Limpieza4Text1;
	public Text Limpieza4Text2;
	public Text Limpieza4Text3;
	public Sprite Limpieza4Imagen;
	public Text Limpieza5Text1;
	public Text Limpieza5Text2;
	public Text Limpieza5Text3;
	public Sprite Limpieza5Imagen;


	//Perfumeria
	public Text Perfumeria1Text1;
	public Text Perfumeria1Text2;
	public Text Perfumeria1Text3;
	public Sprite Perfumeria1Imagen;
	public Text Perfumeria2Text1;
	public Text Perfumeria2Text2;
	public Text Perfumeria2Text3;
	public Sprite Perfumeria2Imagen;
	public Text Perfumeria3Text1;
	public Text Perfumeria3Text2;
	public Text Perfumeria3Text3;
	public Sprite Perfumeria3Imagen;
	public Text Perfumeria4Text1;
	public Text Perfumeria4Text2;
	public Text Perfumeria4Text3;
	public Sprite Perfumeria4Imagen;
	public Text Perfumeria5Text1;
	public Text Perfumeria5Text2;
	public Text Perfumeria5Text3;
	public Sprite Perfumeria5Imagen;

	//Bazar
	public Text Bazar1Text1;
	public Text Bazar1Text2;
	public Text Bazar1Text3;
	public Sprite Bazar1Imagen;
	public Text Bazar2Text1;
	public Text Bazar2Text2;
	public Text Bazar2Text3;
	public Sprite Bazar2Imagen;
	public Text Bazar3Text1;
	public Text Bazar3Text2;
	public Text Bazar3Text3;
	public Sprite Bazar3Imagen;
	public Text Bazar4Text1;
	public Text Bazar4Text2;
	public Text Bazar4Text3;
	public Sprite Bazar4Imagen;
	public Text Bazar5Text1;
	public Text Bazar5Text2;
	public Text Bazar5Text3;
	public Sprite Bazar5Imagen;

	//Perecederos
	public Text Perecederos1Text1;
	public Text Perecederos1Text2;
	public Text Perecederos1Text3;
	public Sprite Perecederos1Imagen;
	public Text Perecederos2Text1;
	public Text Perecederos2Text2;
	public Text Perecederos2Text3;
	public Sprite Perecederos2Imagen;
	public Text Perecederos3Text1;
	public Text Perecederos3Text2;
	public Text Perecederos3Text3;
	public Sprite Perecederos3Imagen;
	public Text Perecederos4Text1;
	public Text Perecederos4Text2;
	public Text Perecederos4Text3;
	public Sprite Perecederos4Imagen;
	public Text Perecederos5Text1;
	public Text Perecederos5Text2;
	public Text Perecederos5Text3;
	public Sprite Perecederos5Imagen;


	void Start(){
		//HOME
		Home1Text1.text = "$6,999";
		Home1Text2.text = "S&P";
		Home1Text3.text = "Tomate en Latas";
		Home2Text1.text = "$4,489";
		Home2Text2.text = "HELLMANN'S";
		Home2Text3.text = "Mayonesa sachet x 118gr";
		Home3Text1.text = "$7,699";
		Home3Text2.text = "KNORR";
		Home3Text3.text = "Caldos varios sabores x6un";
		Home4Text1.text = "$11,699";
		Home4Text2.text = "GALLO ORO";
		Home4Text3.text = "Arroz estuche x1kg";
		Home5Text1.text = "$7,499";
		Home5Text2.text = "CADBURY";
		Home5Text3.text = "Chocolate yogurt frutilla x27gr";

		//ALMACEN
		Almacen1Text1.text = "$22,799";
		Almacen1Text2.text = "NATURA";
		Almacen1Text3.text = "Aceite vegetal x120gr";
		Almacen2Text1.text = "$8,999";
		Almacen2Text2.text = "LUCCHETTI";
		Almacen2Text3.text = "Fideos ave maria x500gr";
		Almacen3Text1.text = "$3,199";
		Almacen3Text2.text = "53";
		Almacen3Text3.text = "Arroz largo fino x500gr";
		Almacen4Text1.text = "$13,499";
		Almacen4Text2.text = "ARLISTAN";
		Almacen4Text3.text = "Cafe instantaneo x50gr";
		Almacen5Text1.text = "$13,899";
		Almacen5Text2.text = "NOEL";
		Almacen5Text3.text = "Mermelada light varios sabores x390gr";

		//Galletitas
		Galletitas1Text1.text = "$22,999";
		Galletitas1Text2.text = "PEPITOS";
		Galletitas1Text3.text = "Galletitas 3u x118gr";
		Galletitas2Text1.text = "$7,699";
		Galletitas2Text2.text = "DON SATUR PALMERITAS";
		Galletitas2Text3.text = "Galletitas x180gr";
		Galletitas3Text1.text = "$15,599";
		Galletitas3Text2.text = "VARIEDAD";
		Galletitas3Text3.text = "Galletitas dorada x300gr";
		Galletitas4Text1.text = "$6,699";
		Galletitas4Text2.text = "SONRISAS";
		Galletitas4Text3.text = "Galletitas frambuesa x118gr";
		Galletitas5Text1.text = "$7,499";
		Galletitas5Text2.text = "BAGLEY FAMILIAR";
		Galletitas5Text3.text = "Galletitas salvado x241gr";

		//Kiosco
		Kiosco1Text1.text = "$34,999";
		Kiosco1Text2.text = "LIPO";
		Kiosco1Text3.text = "Caramelos bolon x907gr";
		Kiosco2Text1.text = "$32,999";
		Kiosco2Text2.text = "PICO DULCE";
		Kiosco2Text3.text = "Caramelos x450gr";
		Kiosco3Text1.text = "$4,299";
		Kiosco3Text2.text = "JORGITO";
		Kiosco3Text3.text = "Alfajor x50gr";
		Kiosco4Text1.text = "$7,499";
		Kiosco4Text2.text = "PEPITOS";
		Kiosco4Text3.text = "Alfajor triple x57gr";
		Kiosco5Text1.text = "$30,999";
		Kiosco5Text2.text = "SHOT";
		Kiosco5Text3.text = "Chocolate con mani x170gr";

		//Mascotas
		Mascotas1Text1.text = "$345,899";
		Mascotas1Text2.text = "PEDIGREE";
		Mascotas1Text3.text = "Adulto Carne-Pollo-Cerdo x15kg";
		Mascotas2Text1.text = "$30,999";
		Mascotas2Text2.text = "DOGUI";
		Mascotas2Text3.text = "Varios sabores x1,5kg";
		Mascotas3Text1.text = "$79,999";
		Mascotas3Text2.text = "DOG CHOW ESSENTIALS";
		Mascotas3Text3.text = "Cachorros x1.2kg";
		Mascotas4Text1.text = "$22,999";
		Mascotas4Text2.text = "BACAN";
		Mascotas4Text3.text = "Perro adulto carne x1.5kg";
		Mascotas5Text1.text = "$367,999";
		Mascotas5Text2.text = "WHISKAS";
		Mascotas5Text3.text = "Adulto pescado x10kg";

		//Bebidas
		Bebidas1Text1.text = "$7,499";
		Bebidas1Text2.text = "SER WE";
		Bebidas1Text3.text = "Sabores x500cc";
		Bebidas2Text1.text = "$11,499";
		Bebidas2Text2.text = "IVESS";
		Bebidas2Text3.text = "Soda sifon descartable x2lt";
		Bebidas3Text1.text = "$9,999";
		Bebidas3Text2.text = "V";
		Bebidas3Text3.text = "Energizante x473ml";
		Bebidas4Text1.text = "$9,999";
		Bebidas4Text2.text = "SCHNEIDER";
		Bebidas4Text3.text = "Cerveza porron x330cc";
		Bebidas5Text1.text = "$53,519";
		Bebidas5Text2.text = "BRANCA MENTA";
		Bebidas5Text3.text = "Fernet x450cc";

		//Bodega
		Bodega1Text1.text = "$39,999";
		Bodega1Text2.text = "SAN HUBERTO";
		Bodega1Text3.text = "Vino roble varietal x750 cc";
		Bodega2Text1.text = "$62,419";
		Bodega2Text2.text = "LATITUD 33";
		Bodega2Text3.text = "Vino varietal x750cc";
		Bodega3Text1.text = "$31,999";
		Bodega3Text2.text = "FINCAS LAS MORAS";
		Bodega3Text3.text = "Vino varietal x750cc";
		Bodega4Text1.text = "$24,399";
		Bodega4Text2.text = "FINCA NATALINA";
		Bodega4Text3.text = "Vina varietal x750cc";
		Bodega5Text1.text = "$131,149";
		Bodega5Text2.text = "CHANDON";
		Bodega5Text3.text = "Champagne delice x750cc";

		//Limpieza
		Limpieza1Text1.text = "$14,999";
		Limpieza1Text2.text = "ELEGANTE";
		Limpieza1Text3.text = "Papel higienico blanco 30mt x6u";
		Limpieza2Text1.text = "$2,989";
		Limpieza2Text2.text = "VUAL";
		Limpieza2Text3.text = "Papel higienico 50mt x1u";
		Limpieza3Text1.text = "$29,799";
		Limpieza3Text2.text = "OFF";
		Limpieza3Text3.text = "Repelente x166cc";
		Limpieza4Text1.text = "$22,499";
		Limpieza4Text2.text = "CIF ACTIVE GEL";
		Limpieza4Text3.text = "Detergente varias fragancias x600ml";
		Limpieza5Text1.text = "$18,99";
		Limpieza5Text2.text = "PROCENEX";
		Limpieza5Text3.text = "Limpiador varias fragancias x1,8lt";

		//Perfumeria
		Perfumeria1Text1.text = "$24,999";
		Perfumeria1Text2.text = "PANTENE MAX PRO-V";
		Perfumeria1Text3.text = "Shampoo/Acondicionador x200ml";
		Perfumeria2Text1.text = "$21,399";
		Perfumeria2Text2.text = "DOVE MEN";
		Perfumeria2Text3.text = "Shampoo/Acondicionador x200ml";
		Perfumeria3Text1.text = "$47,799";
		Perfumeria3Text2.text = "H&S/H&S MEN";
		Perfumeria3Text3.text = "Shampoo/Acondicionador x400ml";
		Perfumeria4Text1.text = "$32,999";
		Perfumeria4Text2.text = "DOVE MEN";
		Perfumeria4Text3.text = "Antitranspirante clean comfort aerosol x89gr";
		Perfumeria5Text1.text = "$10,299";
		Perfumeria5Text2.text = "KOLYNOS";
		Perfumeria5Text3.text = "Crema dental super blanco x70gr";

		//Bazar
		Bazar1Text1.text = "$7,999";
		Bazar1Text2.text = "RIGOLLEAU";
		Bazar1Text3.text = "Vaso con granel";
		Bazar2Text1.text = "$15,999";
		Bazar2Text2.text = "RIGOLLEAU";
		Bazar2Text3.text = "Vaso pinta con granel";
		Bazar3Text1.text = "$224,999";
		Bazar3Text2.text = "CAROL";
		Bazar3Text3.text = "Bifera teflon rayada";
		Bazar4Text1.text = "$438,999";
		Bazar4Text2.text = "CAROL";
		Bazar4Text3.text = "Cacerola teflon x20cm";
		Bazar5Text1.text = "$61,999";
		Bazar5Text2.text = "ILKO";
		Bazar5Text3.text = "Rallador 4 usos";

		//Perecederos
		Perecederos1Text1.text = "$12,299";
		Perecederos1Text2.text = "CITRIC";
		Perecederos1Text3.text = "Jugo x500cc varios sabores";
		Perecederos2Text1.text = "$12,999";
		Perecederos2Text2.text = "ORALI";
		Perecederos2Text3.text = "Fidddeos al huevo x500gr";
		Perecederos3Text1.text = "$15,499";
		Perecederos3Text2.text = "LA SALTEÑA";
		Perecederos3Text3.text = "Tapas para empanadas x15u";
		Perecederos4Text1.text = "$16,989";
		Perecederos4Text2.text = "LA SERENISIMA";
		Perecederos4Text3.text = "Dulce de leche colonial x400gr";
		Perecederos5Text1.text = "$24,999";
		Perecederos5Text2.text = "DANICA";
		Perecederos5Text3.text = "Margarina calsica x500gr";

	}
	//HOME
	public void Home1(){
		Precio.text = Home1Text1.text;
		PrecioIva.text = "$8,469";
		Nombre.text = Home1Text2.text;
		Descripcion.text = Home1Text3.text;
		ImagenProducto.sprite = Home1Imagen;
		Oferta.SetActive (true);
	}
	public void Home2(){
		Precio.text = Home2Text1.text;
		PrecioIva.text = "$5,432";
		Nombre.text = Home2Text2.text;
		Descripcion.text = Home2Text3.text;
		ImagenProducto.sprite = Home2Imagen;
		Oferta.SetActive (true);
	}
	public void Home3(){
		Precio.text = Home3Text1.text;
		PrecioIva.text = "$9,316";
		Nombre.text = Home3Text2.text;
		Descripcion.text = Home3Text3.text;
		ImagenProducto.sprite = Home3Imagen;
		Oferta.SetActive (true);
	}
	public void Home4(){
		Precio.text = Home4Text1.text;
		PrecioIva.text = "$13,699";
		Nombre.text = Home4Text2.text;
		Descripcion.text = Home4Text3.text;
		ImagenProducto.sprite = Home4Imagen;
		Oferta.SetActive (true);
	}
	public void Home5(){
		Precio.text = Home5Text1.text;
		PrecioIva.text = "$9,074";
		Nombre.text = Home5Text2.text;
		Descripcion.text = Home5Text3.text;
		ImagenProducto.sprite = Home5Imagen;
		Oferta.SetActive (true);
	}

	//ALMACEN
	public void Almacen1(){
		Precio.text = Almacen1Text1.text;
		PrecioIva.text = "$27,587";
		Nombre.text = Almacen1Text2.text;
		Descripcion.text = Almacen1Text3.text;
		ImagenProducto.sprite = Almacen1Imagen;
	}
	public void Almacen2(){
		Precio.text = Almacen2Text1.text;
		PrecioIva.text = "$10,889";
		Nombre.text = Almacen2Text2.text;
		Descripcion.text = Almacen2Text3.text;
		ImagenProducto.sprite = Almacen2Imagen;
	}
	public void Almacen3(){
		Precio.text = Almacen3Text1.text;
		PrecioIva.text = "$3,871";
		Nombre.text = Almacen3Text2.text;
		Descripcion.text = Almacen3Text3.text;
		ImagenProducto.sprite = Almacen3Imagen;
	}
	public void Almacen4(){
		Precio.text = Almacen4Text1.text;
		PrecioIva.text = "$16,334";
		Nombre.text = Almacen4Text2.text;
		Descripcion.text = Almacen4Text3.text;
		ImagenProducto.sprite = Almacen4Imagen;
	}
	public void Almacen5(){
		Precio.text = Almacen5Text1.text;
		PrecioIva.text = "$16,899";
		Nombre.text = Almacen5Text2.text;
		Descripcion.text = Almacen5Text3.text;
		ImagenProducto.sprite = Almacen5Imagen;
	}

	//Galletitas
	public void Galletitas1(){
		Precio.text = Galletitas1Text1.text;
			PrecioIva.text = "$27,829";
		Nombre.text =Galletitas1Text2.text;
		Descripcion.text = Galletitas1Text3.text;
		ImagenProducto.sprite = Galletitas1Imagen;
		}
	public void Galletitas2(){
		Precio.text = Galletitas2Text1.text;
			PrecioIva.text = "$9,316";
		Nombre.text = Galletitas2Text2.text;
		Descripcion.text = Galletitas2Text3.text;
		ImagenProducto.sprite =Galletitas2Imagen;
		}
	public void Galletitas3(){
		Precio.text = Galletitas3Text1.text;
			PrecioIva.text = "$18,875";
		Nombre.text = Galletitas3Text2.text;
		Descripcion.text =Galletitas3Text3.text;
		ImagenProducto.sprite = Galletitas3Imagen;
		}
	public void Galletitas4(){
		Precio.text = Galletitas4Text1.text;
			PrecioIva.text = "$8,106";
		Nombre.text =Galletitas4Text2.text;
		Descripcion.text = Galletitas4Text3.text;
		ImagenProducto.sprite = Galletitas4Imagen;
		}
	public void Galletitas5(){
		Precio.text = Galletitas5Text1.text;
			PrecioIva.text = "$9,074";
		Nombre.text = Galletitas5Text2.text;
		Descripcion.text = Galletitas5Text3.text;
		ImagenProducto.sprite = Galletitas5Imagen;
		}


	//Kiosco
	public void Kiosco1(){
		Precio.text = Kiosco1Text1.text;
			PrecioIva.text = "$42,349";
		Nombre.text =Kiosco1Text2.text;
		Descripcion.text = Kiosco1Text3.text;
		ImagenProducto.sprite = Kiosco1Imagen;
		}
	public void Kiosco2(){
		Precio.text = Kiosco2Text1.text;
			PrecioIva.text = "$39,929";
		Nombre.text = Kiosco2Text2.text;
		Descripcion.text = Kiosco2Text3.text;
		ImagenProducto.sprite =Kiosco2Imagen;
		}
	public void Kiosco3(){
		Precio.text = Kiosco3Text1.text;
			PrecioIva.text = "$5,202";
		Nombre.text = Kiosco3Text2.text;
		Descripcion.text =Kiosco3Text3.text;
		ImagenProducto.sprite = Kiosco3Imagen;
		}
	public void Kiosco4(){
		Precio.text = Kiosco4Text1.text;
			PrecioIva.text = "$9,074";
		Nombre.text =Kiosco4Text2.text;
		Descripcion.text = Kiosco4Text3.text;
		ImagenProducto.sprite = Kiosco4Imagen;
		}
	public void Kiosco5(){
		Precio.text = Kiosco5Text1.text;
			PrecioIva.text = "$37,509";
		Nombre.text = Kiosco5Text2.text;
		Descripcion.text = Kiosco5Text3.text;
		ImagenProducto.sprite = Kiosco5Imagen;
		}

	//Mascotas
	public void Mascotas1(){
		Precio.text = Mascotas1Text1.text;
			PrecioIva.text = "$418,538";
		Nombre.text =Mascotas1Text2.text;
		Descripcion.text = Mascotas1Text3.text;
		ImagenProducto.sprite = Mascotas1Imagen;
		}
	public void Mascotas2(){
		Precio.text = Mascotas2Text1.text;
			PrecioIva.text = "$37,509";
		Nombre.text = Mascotas2Text2.text;
		Descripcion.text = Mascotas2Text3.text;
		ImagenProducto.sprite =Mascotas2Imagen;
		}
	public void Mascotas3(){
		Precio.text = Mascotas3Text1.text;
			PrecioIva.text = "$96,799";
		Nombre.text = Mascotas3Text2.text;
		Descripcion.text =Mascotas3Text3.text;
		ImagenProducto.sprite = Mascotas3Imagen;
		}
	public void Mascotas4(){
		Precio.text = Mascotas4Text1.text;
			PrecioIva.text = "$27,829";
		Nombre.text =Mascotas4Text2.text;
		Descripcion.text = Mascotas4Text3.text;
		ImagenProducto.sprite = Mascotas4Imagen;
		}
	public void Mascotas5(){
		Precio.text = Mascotas5Text1.text;
			PrecioIva.text = "$445,279";
		Nombre.text = Mascotas5Text2.text;
		Descripcion.text = Mascotas5Text3.text;
		ImagenProducto.sprite = Mascotas5Imagen;
		}

	//Bebidas
	public void Bebidas1(){
		Precio.text = Bebidas1Text1.text;
			PrecioIva.text = "$9,074";
		Nombre.text =Bebidas1Text2.text;
		Descripcion.text = Bebidas1Text3.text;
		ImagenProducto.sprite = Bebidas1Imagen;
		}
	public void Bebidas2(){
		Precio.text = Bebidas2Text1.text;
			PrecioIva.text = "$13,914";
		Nombre.text = Bebidas2Text2.text;
		Descripcion.text = Bebidas2Text3.text;
		ImagenProducto.sprite =Bebidas2Imagen;
		}
	public void Bebidas3(){
		Precio.text = Bebidas3Text1.text;
			PrecioIva.text = "$12,099";
		Nombre.text = Bebidas3Text2.text;
		Descripcion.text =Bebidas3Text3.text;
		ImagenProducto.sprite = Bebidas3Imagen;
		}
	public void Bebidas4(){
		Precio.text = Bebidas4Text1.text;
			PrecioIva.text = "$12,099";
		Nombre.text =Bebidas4Text2.text;
		Descripcion.text = Bebidas4Text3.text;
		ImagenProducto.sprite = Bebidas4Imagen;
		}
	public void Bebidas5(){
		Precio.text = Bebidas5Text1.text;
			PrecioIva.text = "$64,768";
		Nombre.text = Bebidas5Text2.text;
		Descripcion.text = Bebidas5Text3.text;
		ImagenProducto.sprite = Bebidas5Imagen;
		}

	//Bodega
	public void Bodega1(){
		Precio.text = Bodega1Text1.text;
			PrecioIva.text = "$48,399";
		Nombre.text =Bodega1Text2.text;
		Descripcion.text = Bodega1Text3.text;
		ImagenProducto.sprite = Bodega1Imagen;
		}
	public void Bodega2(){
		Precio.text = Bodega2Text1.text;
			PrecioIva.text = "$75,527";
		Nombre.text = Bodega2Text2.text;
		Descripcion.text = Bodega2Text3.text;
		ImagenProducto.sprite =Bodega2Imagen;
		}
	public void Bodega3(){
		Precio.text = Bodega3Text1.text;
			PrecioIva.text = "$38,719";
		Nombre.text = Bodega3Text2.text;
		Descripcion.text =Bodega3Text3.text;
		ImagenProducto.sprite = Bodega3Imagen;
		}
	public void Bodega4(){
		Precio.text = Bodega4Text1.text;
			PrecioIva.text = "$29,523";
		Nombre.text =Bodega4Text2.text;
		Descripcion.text = Bodega4Text3.text;
		ImagenProducto.sprite = Bodega4Imagen;
		}
	public void Bodega5(){
		Precio.text = Bodega5Text1.text;
			PrecioIva.text = "$158,690";
		Nombre.text = Bodega5Text2.text;
		Descripcion.text = Bodega5Text3.text;
		ImagenProducto.sprite = Bodega5Imagen;
		}

	//Limpieza
	public void Limpieza1(){
		Precio.text = Limpieza1Text1.text;
		PrecioIva.text = "$18,149";
		Nombre.text =Limpieza1Text2.text;
		Descripcion.text = Limpieza1Text3.text;
		ImagenProducto.sprite = Limpieza1Imagen;
	}
	public void Limpieza2(){
		Precio.text = Limpieza2Text1.text;
		PrecioIva.text = "$3,617";
		Nombre.text = Limpieza2Text2.text;
		Descripcion.text = Limpieza2Text3.text;
		ImagenProducto.sprite =Limpieza2Imagen;
	}
	public void Limpieza3(){
		Precio.text = Limpieza3Text1.text;
		PrecioIva.text = "$36,057";
		Nombre.text = Limpieza3Text2.text;
		Descripcion.text =Limpieza3Text3.text;
		ImagenProducto.sprite = Limpieza3Imagen;
	}
	public void Limpieza4(){
		Precio.text = Limpieza4Text1.text;
		PrecioIva.text = "$27,224";
		Nombre.text =Limpieza4Text2.text;
		Descripcion.text = Limpieza4Text3.text;
		ImagenProducto.sprite = Limpieza4Imagen;
	}
	public void Limpieza5(){
		Precio.text = Limpieza5Text1.text;
		PrecioIva.text = "$22,989";
		Nombre.text = Limpieza5Text2.text;
		Descripcion.text = Limpieza5Text3.text;
		ImagenProducto.sprite = Limpieza5Imagen;
	}


	//Perfumeria
	public void Perfumeria1(){
		Precio.text = Perfumeria1Text1.text;
			PrecioIva.text = "$30,249";
		Nombre.text =Perfumeria1Text2.text;
		Descripcion.text = Perfumeria1Text3.text;
		ImagenProducto.sprite = Perfumeria1Imagen;
		}
	public void Perfumeria2(){
		Precio.text = Perfumeria2Text1.text;
			PrecioIva.text = "$25,893";
		Nombre.text = Perfumeria2Text2.text;
		Descripcion.text = Perfumeria2Text3.text;
		ImagenProducto.sprite =Perfumeria2Imagen;
		}
	public void Perfumeria3(){
		Precio.text = Perfumeria3Text1.text;
			PrecioIva.text = "$57,837";
		Nombre.text = Perfumeria3Text2.text;
		Descripcion.text =Perfumeria3Text3.text;
		ImagenProducto.sprite = Perfumeria3Imagen;
		}
	public void Perfumeria4(){
		Precio.text = Perfumeria4Text1.text;
			PrecioIva.text = "$39,929";
		Nombre.text =Perfumeria4Text2.text;
		Descripcion.text = Perfumeria4Text3.text;
		ImagenProducto.sprite = Perfumeria4Imagen;
		}
	public void Perfumeria5(){
		Precio.text = Perfumeria5Text1.text;
			PrecioIva.text = "$12,462";
		Nombre.text = Perfumeria5Text2.text;
		Descripcion.text = Perfumeria5Text3.text;
		ImagenProducto.sprite = Perfumeria5Imagen;
		}

	//Bazar
	public void Bazar1(){
		Precio.text = Bazar1Text1.text;
			PrecioIva.text = "$9,679";
		Nombre.text =Bazar1Text2.text;
		Descripcion.text = Bazar1Text3.text;
		ImagenProducto.sprite = Bazar1Imagen;
		}
	public void Bazar2(){
		Precio.text = Bazar2Text1.text;
			PrecioIva.text = "$19,359";
		Nombre.text = Bazar2Text2.text;
		Descripcion.text = Bazar2Text3.text;
		ImagenProducto.sprite =Bazar2Imagen;
		}
	public void Bazar3(){
		Precio.text = Bazar3Text1.text;
			PrecioIva.text = "$272,249";
		Nombre.text = Bazar3Text2.text;
		Descripcion.text =Bazar3Text3.text;
		ImagenProducto.sprite = Bazar3Imagen;
		}
	public void Bazar4(){
		Precio.text = Bazar4Text1.text;
			PrecioIva.text = "$531,189";
		Nombre.text =Bazar4Text2.text;
		Descripcion.text = Bazar4Text3.text;
		ImagenProducto.sprite = Bazar4Imagen;
		}
	public void Bazar5(){
		Precio.text = Bazar5Text1.text;
			PrecioIva.text = "$75,019";
		Nombre.text = Bazar5Text2.text;
		Descripcion.text = Bazar5Text3.text;
		ImagenProducto.sprite = Bazar5Imagen;
		}

	//Perecederos
	public void Perecederos1(){
		Precio.text = Perecederos1Text1.text;
		PrecioIva.text = "$14,882";
		Nombre.text =Perecederos1Text2.text;
		Descripcion.text = Perecederos1Text3.text;
		ImagenProducto.sprite = Perecederos1Imagen;
	}
	public void Perecederos2(){
		Precio.text = Perecederos2Text1.text;
		PrecioIva.text = "$15,729";
		Nombre.text = Perecederos2Text2.text;
		Descripcion.text = Perecederos2Text3.text;
		ImagenProducto.sprite =Perecederos2Imagen;
	}
	public void Perecederos3(){
		Precio.text = Perecederos3Text1.text;
		PrecioIva.text = "$18,754";
		Nombre.text = Perecederos3Text2.text;
		Descripcion.text =Perecederos3Text3.text;
		ImagenProducto.sprite = Perecederos3Imagen;
	}
	public void Perecederos4(){
		Precio.text = Perecederos4Text1.text;
		PrecioIva.text = "$20,557";
		Nombre.text =Perecederos4Text2.text;
		Descripcion.text = Perecederos4Text3.text;
		ImagenProducto.sprite = Perecederos4Imagen;
	}
	public void Perecederos5(){
		Precio.text = Perecederos5Text1.text;
		PrecioIva.text = "$30,249";
		Nombre.text = Perecederos5Text2.text;
		Descripcion.text = Perecederos5Text3.text;
		ImagenProducto.sprite = Perecederos5Imagen;
	}
}
