using UnityEngine;
using System.Collections;

public class Touch : MonoBehaviour {
	private Controls player;

	void Start() {
		player = FindObjectOfType<Controls>();
	}

	public void LeftArrow() {
		player.moveRight = false;
		player.moveLeft = true;
	}

	public void RightArrow() {
		player.moveRight = true;
		player.moveLeft = false;
	}

	public void ReleaseLeftArrow() {
		player.moveLeft = false;
	}

	public void ReleaseRightArrow() {
		player.moveRight = false;

	}

	public void Jump() {
		player.isJumping = true;
	}

	public void Falling() {
		player.isJumping = false;
	}
}

