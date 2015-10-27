using UnityEngine;
using System.Collections;

public class Reticle : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1)) {
					transform.localScale += new Vector3 (0.06f, 0.06f, 0);
				}
		if (Input.GetMouseButtonUp (1)) {
			transform.localScale += new Vector3 (-0.06F, -0.06f, 0);}
	}
	}
