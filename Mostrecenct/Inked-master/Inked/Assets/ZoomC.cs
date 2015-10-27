using UnityEngine;
using System.Collections;

public class ZoomC : MonoBehaviour {
	public Vector3 HipPose;
	public Vector3 AimPose;
	public float zoomin;
	public float zoomout;
	public AnimationClip ZoomIn;
	public AnimationClip ZoomOut;
	public GameObject MainCam;


	// Use this for initialization
	void Start () {
		transform.localPosition = HipPose;
		MainCam = GameObject.FindGameObjectWithTag("MainCamera");

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire2")){
			transform.localPosition = AimPose;
			MainCam.camera.fieldOfView = zoomin;
		}
		if (!Input.GetButton("Fire2")){
			transform.localPosition = HipPose;
			MainCam.camera.fieldOfView = zoomout;
		}
	}
	}

