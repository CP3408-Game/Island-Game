using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class charControl : MonoBehaviour {

	private Rigidbody rb;
	public GameObject player;
	public GameObject plrRightArm;
	float plrMoveSpd;
	public GameObject charCam;
	private float translation;
	private float straffe;
	public Animation shootAnim;
	public Rigidbody rightArm;
	public GameObject testBull;
	public float cooldown;
	int playerHp = 100;



	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		GameObject testBull = (GameObject)Resources.Load("Bullet");
		rightArm = plrRightArm.GetComponent<Rigidbody>();
		Physics.IgnoreLayerCollision(8, 11);


	}

	// Update is called once per frame
	void Update () {
		//plrMoveSpd = 17f;
		Time.timeScale = 1;

		shootAnim = GetComponentInChildren<Animation>();



		translation = Input.GetAxis("Vertical") * plrMoveSpd;
		straffe = Input.GetAxis("Horizontal") * plrMoveSpd;
		translation *= Time.deltaTime;
		straffe *= Time.deltaTime;

		rb.transform.Translate(straffe, 0, translation);

		if (Input.GetKey(KeyCode.LeftShift)) {
			plrMoveSpd = 25f;
		} else {
			plrMoveSpd = 18f;
		}

		if (cooldown > 0) {
			cooldown -= Time.deltaTime;
		}
		else if (Input.GetMouseButton(0)) {
			shootAnim.Play();
			Vector2 position = new Vector2(rightArm.position.y, rightArm.position.x);
			GameObject nb = (GameObject) Instantiate(testBull, rightArm.position, transform.rotation);
			nb.GetComponent<Rigidbody>().AddForce(charCam.transform.forward * 3000);
			cooldown = 1f;
	

		
		}

		if (playerHp <= 0) {
			SceneManager.LoadScene("gameScene");
		}
			
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.layer == 9) {
			playerHp -= 10;
			print(playerHp);

		}
	}
}
