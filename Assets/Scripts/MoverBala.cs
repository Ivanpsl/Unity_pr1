using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBala : MonoBehaviour {


	public float velocidad;
	void Start(){
		GetComponent<Rigidbody2D> ().velocity = transform.up * velocidad;
		Invoke ("Limpiar", 10f);
	}

	void Limpiar(){
		Destroy (gameObject);
	}
}
