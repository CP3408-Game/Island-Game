using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public GameObject smoke;
	public Transform smokeSpawn;
	//public int enemyHealth;
		
	// Update is called once per frame
	void Update () {
		if (!gameObject.activeSelf) {
			Instantiate (smoke, smokeSpawn.position, smokeSpawn.rotation);
		}
	}
}
