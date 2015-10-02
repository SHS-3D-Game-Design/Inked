using UnityEngine;
using System.Collections;

public class Animations : MonoBehaviour {

	public bool animation_bool;
	void Update()
	{
		if(animation_bool == true)
		{
			animation.Play("Gun zoom");
		}
		if(Input.GetButtonDown("Fire2"))
		{
			animation_bool = true;
		}

		if (Input.GetButtonUp ("Fire2")) {
						animation_bool = false;
				}
		if (animation_bool == false) {
						animation.Stop ("Gun zoom");
				}
		
		
		
	}
}