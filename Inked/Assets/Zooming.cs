using UnityEngine;
using System.Collections;

public class Zooming : MonoBehaviour {
	public AnimationClip Zoomin;
	public AnimationClip Zoomout;
	public float x;
	public float y;
	public float z;

	void Start(){
		animation.Stop ("Zoomin");
		animation.Stop ("Zoomout");
	}
	void Update ()
	{
		if(Input.GetMouseButtonDown(1)){
			animation.Play("Zoomin");
		}
		
		
		else if(!Input.GetMouseButtonDown(1)){
			
			animation.Play("Zoomout");
			
		}
	}
}
