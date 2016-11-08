using UnityEngine;
using System.Collections;

public class playSoundOnCollision : MonoBehaviour {

	private AudioSource myAudioSource;
	void Start (){
		myAudioSource = GetComponent<AudioSource> (); 
	}

	void OnCollisionEnter(Collision collision){
		myAudioSource.Play (); 

// 		some examples of other physics info you can get form the collision:
//		Debug.Log(collision.relativeVelocity);
//		Debug.Log(collision.relativeVelocity.magnitude);
//		Debug.Log(collision.impulse.magnitude);

//		base the volumeof the AudioClip playing on the magnitude of relative velocity: 
		myAudioSource.volume = collision.relativeVelocity.magnitude / 3;

//		base the pitch of AudioClip playing on the magnitude of relative velocity: 
		myAudioSource.pitch = collision.relativeVelocity.magnitude / 3;


	}
}
