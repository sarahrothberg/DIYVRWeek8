using System;
using System.Collections;
using UnityEngine;
using VRStandardAssets.Common;
using VRStandardAssets.Utils;

public class changeColorOnHover : MonoBehaviour

{

	private VRInteractiveItem myInteractiveItem;                    

	private void Awake()
	{
		myInteractiveItem = GetComponent<VRInteractiveItem>();


	}

	//when this script is enabled, bind the "interactiveItem" event to the function below called HandleDown
	private void OnEnable ()
	{
		myInteractiveItem.OnOver += PointerEnter;
	}

	//when this script is disabled, unbindbind the "interactiveItem" event to the function below called HandleDown
	private void OnDisable ()
	{
		myInteractiveItem.OnOver -= PointerEnter;
	}

	private void PointerEnter()
	{
		GetComponent<Renderer> ().material.color = Color.green;
	}
}