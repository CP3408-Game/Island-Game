using UnityEngine;
using System.Collections;

public class bulletTest : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Physics.GetIgnoreLayerCollision(11, 8);
	
	}
	
	// Update is called once per frame
	void Update () {

		Destroy(this.gameObject, 2f);
	
	}

	void OnCollisionEnter(Collision col) {
		if(col.gameObject.tag == "enemy") {
			Destroy(col.gameObject);
			Destroy(this.gameObject);
		} else {
			Destroy(this.gameObject);
		}
	}
}
