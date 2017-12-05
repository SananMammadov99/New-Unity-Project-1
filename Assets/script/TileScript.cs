using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour {

	public GameObject its;
	public GameObject player;
	private float fallDelay = 1.5f;
	// Use this for initialization
	void Start () {
		its = GameObject.FindGameObjectWithTag("TileManager");
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -30) {
			Destroy (gameObject);
		}
	}

	void OnTriggerExit (Collider other){
		
		if (other.CompareTag ("Player")) {
			its.GetComponent<tileMager> ().SpawnTile ();
			StartCoroutine (fallDown());

		}
		
	}

	IEnumerator fallDown () {
		yield return new WaitForSeconds (fallDelay);
		GetComponent<Rigidbody> ().isKinematic = false;
	}
}
