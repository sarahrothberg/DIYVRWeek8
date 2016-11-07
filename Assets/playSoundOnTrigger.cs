using UnityEngine;
using System.Collections;

public class playSoundOnTrigger : MonoBehaviour {


	void OnTriggerEnter(){
		GetComponent<AudioSource> ().Play(); 
	}
}
