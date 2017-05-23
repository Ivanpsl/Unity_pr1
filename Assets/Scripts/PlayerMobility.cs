using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMobility : MonoBehaviour {

	public float velocidad;

	public GameObject disparo;
	public Transform hardPoint;

	public float cadenciaDefecto;
	private float siguienteDisparo;

	void Start(){

	}
	void FixedUpdate(){

		//obtenemos la posicion del raton
		var posicionRaton = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, Input.mousePosition.z));
		/*
		 * Quaternion.LookRotation(vector3.posicionA la que mirar, vector3.Posicion arriba/abajo)
		 * 
		 * transform.position: posicion que mira actualmente
		 * - posicion del raton = distancia entre posicion actual y la del raton
		 * */
		Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint (transform.position);
		float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle - 90f, Vector3.forward);
	


	

		//para que no rote en Y
		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);

		//movimiento
		//var  value = transform.position.y - Input.mousePosition.y;


		float input = Input.GetAxis("Vertical"); //Si hacemos un Imput de una tecla vertical => W/S o flecha arriba/abajo	
		print(Time.deltaTime*100);
		//si el imput es positivo W o flecha arriba
		if (input > 0) {
			GetComponent<Rigidbody2D> ().AddForce (transform.up * obtenerVelocidad () * input *(Time.deltaTime *100));
		}
	}

	void Update(){



		if (Input.GetButton ("Fire1") && Time.time > siguienteDisparo) {
			siguienteDisparo = Time.time + obtenerCadencia();
			//GameObject balaClon =
			//Instanciar (objeto, posicion, rotacion)
			Instantiate (disparo, hardPoint.position, hardPoint.rotation); //as GameObject;
		}
	}


	/**
	 * Metodo con el que obtendremos la velocidad en funcion de distintas caracteristicas 
	 * */
	float obtenerVelocidad(){

		return velocidad;
	}

	float obtenerCadencia(){
		return cadenciaDefecto;
	}
		
}
