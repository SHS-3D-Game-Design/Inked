using UnityEngine;
using System.Collections;

public class ZoomEffect : MonoBehaviour {
	public GameObject zoomview;

	void Start (){
		zoomview.SetActive(false);
		}
	// Update is called once per frame
	void Update () {
if (Input.GetMouseButtonDown (1)) 
		{zoomview.SetActive(true);
		}
		else{zoomview.SetActive(false);
						}
				}
}

