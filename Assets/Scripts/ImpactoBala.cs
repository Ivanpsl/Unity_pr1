using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactoBala : MonoBehaviour {

	public GameObject explosion; 
	GameObject enemigo;

	void OnTriggerEnter2D(Collider2D obj){
		enemigo = GameObject.FindWithTag ("Enemigo");
		if(enemigo!=null){
			if(obj.Equals(enemigo.GetComponent<Collider2D>())){
				Instantiate (explosion, obj.transform.position, Quaternion.identity);
				Destroy (obj.gameObject);
				Destroy (gameObject);
			}
		}
	}

}
