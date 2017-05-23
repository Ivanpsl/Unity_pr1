using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionScript : MonoBehaviour {


	void Start () {
		Invoke ("Limpiar", 1f);
	}

	void Limpiar(){
		Destroy (gameObject);
	}

}
