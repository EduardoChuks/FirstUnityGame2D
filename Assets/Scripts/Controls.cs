using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

	public Rigidbody2D rb;
	public float movespeed;
	public bool moveRight;
	public bool moveLeft;
	public bool isJumping;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		moveRight = false;
		moveLeft = false;
		isJumping = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow)) {
			rb.velocity = new Vector2(-movespeed, rb.velocity.y);
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			rb.velocity = new Vector2(movespeed, rb.velocity.y);
		}
		if (Input.GetKey (KeyCode.Space)) {
			rb.velocity = new Vector2 (rb.velocity.x, movespeed * 2);
		}
		if (moveLeft) {
			rb.velocity = new Vector2(-movespeed, rb.velocity.y);
		}
		if (moveRight) {
			rb.velocity = new Vector2(movespeed, rb.velocity.y);
		}
		if (isJumping) {
			rb.velocity = new Vector2 (rb.velocity.x, movespeed * 2);
		}
	}
}
