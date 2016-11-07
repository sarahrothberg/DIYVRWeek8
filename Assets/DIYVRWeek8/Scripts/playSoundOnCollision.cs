using UnityEngine;
using System.Collections;

public class playSoundOnCollision : MonoBehaviour {

	private AudioSource myAudioSource;
	void Start (){
		myAudioSource = GetComponent<AudioSource> (); 
	}

	void OnCollisionEnter(Collision collision){
		myAudioSource.Play (); 
		//Debug.Log(collision.relativeVelocity);
		//Debug.Log(collision.relativeVelocity.magnitude);
		//Debug.Log(collision.impulse.magnitude);
		//AudioSource.volume = collision.relativeVelocity.magnitude / 3;

	}
}
