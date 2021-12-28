using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {
	public GameObject gameOverscreen;
	public Text scoreUI;
	bool gameOver;
	// Use this for initialization
	void Start () {
		FindObjectOfType<wraparound> ().onPlayerDeath += OnGameOver;
	}

	// Update is called once per frame
	void Update () {
		if (gameOver) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				SceneManager.LoadScene (0);
			}
		}
	}   
	 void OnGameOver(){
		gameOverscreen.SetActive (true);
		scoreUI.text = Time.timeSinceLevelLoad.ToString();
		gameOver = true;
	}
}