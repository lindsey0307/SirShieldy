using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {

	public float speed;
	private Vector3 playerPos = new Vector3(-6f, 0f, 0.5f);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float yPos = transform.position.y + (Input.GetAxis("Vertical") * speed);
		playerPos = new Vector3(-6f, Mathf.Clamp(yPos, -4.23f, 4.27f), 0.5f);
		transform.position = playerPos;
	}
}
