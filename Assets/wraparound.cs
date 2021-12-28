using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wraparound : MonoBehaviour {
	public float speed = 7;

	float screenHalfWidth;
	public event System.Action onPlayerDeath;
	// Use this for initialization
	void Start () {
		float playerhalfwidth = transform.localScale.x / 2f;
		screenHalfWidth = Camera.main.aspect * Camera.main.orthographicSize + playerhalfwidth; 
	}
	
	// Update is called once per frame
	void Update () {
		float inputx = Input.GetAxisRaw("Horizontal");
		float velocity = inputx * speed;
		transform.Translate (Vector2.right * velocity * Time.deltaTime);

		if (transform.position.x > screenHalfWidth) {
			transform.position = new Vector2 (-screenHalfWidth, transform.position.y);
		}
		if (transform.position.x < -screenHalfWidth) {
			transform.position = new Vector2 (screenHalfWidth, transform.position.y);
		}
	}
	void OnTriggerEnter2D(Collider2D triggercollider){
		if (triggercollider.tag == "falling_block") {
			if (onPlayerDeath != null) {
				onPlayerDeath ();
			}

			Destroy (gameObject);
		}
	}
}
