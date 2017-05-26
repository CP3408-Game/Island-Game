using UnityEngine;
using System.Collections;

public class enemyspawner : MonoBehaviour {
	Transform spawnerLoc;
	public GameObject selfSpawner;
	public GameObject spawned;
	float cooldown;

	// Use this for initialization
	void Start () {
		spawnerLoc = selfSpawner.transform;
		GameObject spawned = (GameObject)Resources.Load("enemy");
	}

	void Awake() {
		spawnerLoc = transform;
	}
	
	// Update is called once per frame
	void Update () {

		if (cooldown > 0) {
			cooldown -= Time.deltaTime;
		} else {

			Vector2 position = new Vector2(spawnerLoc.position.y, spawnerLoc.position.x);
			Instantiate(spawned, spawnerLoc.position, transform.rotation);
			cooldown = 4f;
		}
	
	}
}
