using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruirNaveShip_01 : MonoBehaviour {

	public PlayerManager playerManager; 

	public GameObject explosion; 
	GameObject jugador;
	void OnTriggerEnter2D(Collider2D obj){
		jugador = GameObject.FindGameObjectWithTag ("Player");
		if (jugador != null) {
			if (jugador.GetComponent<Collider2D> ().Equals (obj)) {
				Instantiate (explosion, obj.transform.position, Quaternion.identity);
				playerManager.estaVivo = false;
				print (playerManager.estaVivo);
				Destroy (obj.gameObject);
			}
		}
	}
		
}
