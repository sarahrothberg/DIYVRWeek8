using UnityEngine;
using System.Collections;

public class sphereLauncher : MonoBehaviour {

	public GameObject launchable; 
	float launchForce;
	private Transform playerPos; 
	// Use this for initialization

	void Start () {
		launchForce = 1000f; 
		playerPos = Camera.main.transform; 
	}

	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown (0)) {
			Rigidbody launch = Instantiate(launchable, playerPos.position, playerPos.rotation) as Rigidbody;
			//launch.AddForce (playerPos.forward * launchForce);
		}
	}
}
