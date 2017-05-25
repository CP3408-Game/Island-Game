using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject blast;
	public Transform blastSpawn;
	public float blastRate;

	AudioSource fireBallShot;

	private float nextBlast;

	void Start() {
		fireBallShot = GetComponent<AudioSource> ();
	}

	void Update() {
		if (Input.GetButton ("Jump") && Time.time > nextBlast) {
			nextBlast = Time.time + blastRate;
			Instantiate (blast, blastSpawn.position, blastSpawn.rotation);
			fireBallShot.Play ();
		}
	}
}
