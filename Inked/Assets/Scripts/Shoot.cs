using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public GameObject bullets;
	public GameObject splash;
	public float delayTime = 8;
	public GameObject explosionPrefab;

	private float counter = 0;
	void Start (){
		}


	void FixedUpdate () {
		if (Input.GetKey (KeyCode.Mouse0) && counter > delayTime) {
						Instantiate (bullets, transform.position, transform.rotation); 
						counter = 0;

						RaycastHit hit;
						Ray ray = new Ray (transform.position, transform.forward);
						if (Physics.Raycast (ray, out hit, 100f)) {
								Instantiate (splash, hit.point, Quaternion.FromToRotation (Vector3.up, hit.normal));
				Instantiate(explosionPrefab, hit.point,
				            Quaternion.FromToRotation (Vector3.down, hit.normal));

								
						
						}
				}
		counter += Time.deltaTime;
	
	}
	}


