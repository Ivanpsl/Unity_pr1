using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour {

	Animator anim;
	float restartTimer;

	public float restartDelay = 5f;
	public PlayerManager playerManager;

	void Awake(){
		anim = GetComponent<Animator>();
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!playerManager.estaVivo) {
			anim.SetTrigger("GameOver");

			restartTimer += Time.deltaTime;
			if (restartTimer >= restartDelay) {
				SceneManager.LoadScene ("_Scenes/MainMenu");
			}
		}
	}
}
