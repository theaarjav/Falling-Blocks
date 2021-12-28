using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling_blocks : MonoBehaviour {
	public Vector2 speedminmax;
	float speed;
	float visibleHeight;
	// Use this for initialization
	void Start () {
		speed = Mathf.Lerp (speedminmax.x, speedminmax.y, Difficulty.GetDiffPer ());
		visibleHeight = -Camera.main.orthographicSize - transform.localScale.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < visibleHeight) {
			Destroy (gameObject);}
		transform.Translate (Vector3.down * speed * Time.deltaTime);
	}
}
