using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {
	public GameObject fallingBlockPrefab;
	public Vector2 secBtenSpawn;
	float nextSpawnTime;
	public Vector2 spawnsizeMinMax;
	public float fallingAngle;

	Vector2 sizeofhalfscreen;
	// Use this for initialization
	void Start () {
		sizeofhalfscreen = new Vector2 (Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);

	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time> nextSpawnTime){
			float secBetnspawns = Mathf.Lerp (secBtenSpawn.y, secBtenSpawn.x, Difficulty.GetDiffPer());
			float spawnsize = Random.Range (spawnsizeMinMax.x, spawnsizeMinMax.y);
			float angle = Random.Range (-fallingAngle, fallingAngle);
			nextSpawnTime = Time.time + secBetnspawns;
			Vector2 spawnPosition = new Vector2 (Random.Range (-sizeofhalfscreen.x, sizeofhalfscreen.x), sizeofhalfscreen.y + spawnsize);
			GameObject spawnedBlock = (GameObject)Instantiate (fallingBlockPrefab, spawnPosition, Quaternion.Euler(Vector3.one*angle));
			spawnedBlock.transform.localScale = Vector2.one * spawnsize;
		}
}

}