using UnityEngine;
using System.Collections;

public class enemyBehaviour : MonoBehaviour {
	public Transform target;
	public GameObject player;
	public int moveSpeed;
	public int rotationSpeed;

	private Transform myTransform;
	// Use this for initialization
	void Start () {
		GameObject player = GameObject.FindGameObjectWithTag("Player");
		target = player.transform;
	
	}

	void Awake() {
		myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {

		myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);

		myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime; 
	
	}

	void OnCollisionEnter(Collision col) {
		if(col.gameObject.layer == 11) {
			Destroy(this.gameObject);
		} else if (col.gameObject.layer == 4) {
			Destroy(this.gameObject);
		}
	}
}
