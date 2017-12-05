using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour {

	public float speed;

	private Vector3 dir;

	public bool die;

	private bool dieOnce;


	// Use this for initialization
	void Start () {
		dir = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (transform.position.y < 3.4) {
			die = true;
			GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.None;
			GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeRotation;




		}

		if (transform.position.y < -10) {
			SceneManager.LoadSceneAsync (SceneManager.GetActiveScene ().buildIndex);
		}

		if (!die) {
			if (Input.GetMouseButtonDown (0)) {
				if (dir == Vector3.forward) {
					dir = Vector3.left;
				} else {
					dir = Vector3.forward;
				}


			}
			float amountToMove = speed * Time.deltaTime;

			transform.Translate (dir * amountToMove);
		}


	}

}
