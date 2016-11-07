using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.VR; 

    public class MouseRotateVRToggler : MonoBehaviour
    {
		//Example of toggling VRSettings
		private void Update ()
		{
			//If V is pressed, toggle VRSettings.enabled
			if (Input.GetKeyDown(KeyCode.V))
			{
				VRSettings.enabled = !VRSettings.enabled;
				Debug.Log("Changed VRSettings.enabled to:"+VRSettings.enabled);
				GetComponent<SimpleMouseRotator> ().enabled = !GetComponent<SimpleMouseRotator> ().enabled;
			}
		}
	}

