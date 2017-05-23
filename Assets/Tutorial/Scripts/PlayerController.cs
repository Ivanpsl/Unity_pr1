using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	//Las clases no usan constructores. Unity gestiona su construccion.Las clases no son de tipo
	//Objeto como en java, son tipo GameObject 


	/**
	 * Multiplicador de velocidad que usaremos mas adelante.
	 * No no es necesario inicializarlo, 
	 * Por ser publica es posible modificar el valor desde el propio editor 
	*/
	public float velocidad;  

	//funcion start llamada con la inicializacion del objeto antes de que se ejecute un update 
	void Start () {
		
	}
	
	// Update ejecuta el codigo una vez por frame. Puede incluir movimientos, triggers, imputs de usuario....
	void Update () {
		
	}

	/*
	 * fixedUpdate es llamado unos fotogramas por segundo fijos, es decir, no se ve afectado por los FPS a los
	 * que corra el juego, como pasa con Update. Por eso lo usaremos para movimientos y fisicas.
	 * 
	 * (Puede ser util usar la funcion Time.deltaTime, que nos retorna el tiempo transcurrido desde su ultima
	 * llamada)
	 * **/
	void FixedUpdate(){

		//Input retorna 1 o 0 segun el movimiento
		float movHorizontal = Input.GetAxis ("Horizontal");
		float movVertical = Input.GetAxis ("Vertical");


		//RigidBody es el objeto que "interacciona" con las fisicas
		Rigidbody rB = GetComponent<Rigidbody> ();

		//vector3(x,y,z) es una estructura que nos permite operar con posiciones en las dimensiones x y z
		Vector3 movFinal = new Vector3(movHorizontal, 0.0f, movVertical);

		//puesto que del imput obtenemos 1 o 0, usaremos un multiplicador para determinar la velocidad
		rB.velocity = movFinal * velocidad;
	}
}
