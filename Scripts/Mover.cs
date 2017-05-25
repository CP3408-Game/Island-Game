using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	AudioSource fireballFizzleOut;
	//GameObject enemy = GameObject.Find("EnemyController");
	//EnemyController enemyController = enemy.GetComponent<EnemyController>();
	public float speed;
	public float delay;
	public int hitPoints;


	private float timer = 0;
	private bool triggered = false;

		void Start() {
		GetComponent<Rigidbody> ().velocity = transform.forward * speed;
        transform.Rotate(180, 0, 0);
		fireballFizzleOut = GetComponent<AudioSource> ();
		}

		void Update() {
			timer += Time.deltaTime;
			if (timer > delay && !triggered) {
				triggered = true;
				DestroyFireball ();
			}
		}

		void OnTriggerEnter (Collider col) {
			if (col.gameObject.CompareTag("Enemy")) {
				//enemyController.enemyHealth -= hitPoints;
				//enemyHealth -= hitPoints
				//Destroy (col.gameObject);
			}
		}

		void DestroyFireball() {
			Destroy (gameObject);
		}
}
