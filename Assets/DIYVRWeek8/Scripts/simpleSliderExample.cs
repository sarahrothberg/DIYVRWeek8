using UnityEngine;
using System.Collections;
namespace VRStandardAssets.Utils
{
public class simpleSliderExample : MonoBehaviour {

		private SelectionSlider mySelectionSlider;                    

		void OnEnable(){
			mySelectionSlider = GetComponent<SelectionSlider>(); 

			mySelectionSlider.OnBarFilled += sliderSelected;
		}
		
		void sliderSelected () {
			Debug.Log ("slider selected!");
			//add whatever functions you want here. 
		}
	}
}
