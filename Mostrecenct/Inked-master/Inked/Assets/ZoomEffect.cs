using UnityEngine;
using System.Collections;

public class ZoomEffect : MonoBehaviour {
	public GameObject zoomview;
	public Animation zoomviewout;
	public Camera camera;
	public GameObject GunCamera;
	public float speed = 1.0f;
	private int newFoV = 30;
	private int oldFoV = 60;
	void Start (){
		zoomview.SetActive(false);
		Camera.main.fieldOfView = 60;
		GunCamera.SetActive (true);
		zoomviewout.Stop();
		}
	// Update is called once per frame
	void Update () {
if (Input.GetMouseButton (1)) 
		{
			zoomview.SetActive(true);
			zoomviewout.Stop ();
			GunCamera.SetActive(false);
			Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, newFoV, Time.deltaTime /speed);
		}
		else{zoomview.SetActive(false);
			GunCamera.SetActive (true);
			Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, oldFoV, Time.deltaTime /speed);
			zoomviewout.Play();
						}

	}
}


