using UnityEngine;
using System.Collections;

public class Shotgun : MonoBehaviour {
	public GameObject bullets;
	public GameObject splash;
	public float delayTime = 8;
	public GameObject explosionPrefab;
	private float counter = 0;
	public float scaleLimit = 2.0f;    
	public float z = 10f;
	public int count = 20;
	void Update () {
		for( int i = 0; i < count; ++i ) {
			FixedUpdate();
			if(Input.GetKey (KeyCode.Mouse1)){
				scaleLimit = 1f;
				z = 20f;
			}
			if(Input.GetKeyUp (KeyCode.Mouse1)){
				scaleLimit = 2.0f;
				z = 10f;
			}
		}
	}
	void FixedUpdate () {
		if (Input.GetMouseButtonDown(0) && counter > delayTime)
		{
			Vector3 direction = Random.insideUnitCircle * scaleLimit;
			direction.z = z; 
			direction = transform.TransformDirection( direction.normalized );  

			
			Ray r = new Ray( transform.position, direction);
			RaycastHit hit;     
			if( Physics.Raycast( r, out hit) ) {
				Instantiate (splash, hit.point, Quaternion.FromToRotation (Vector3.up, hit.normal));
				Instantiate(explosionPrefab, hit.point, Quaternion.FromToRotation (Vector3.up, hit.normal));
				Debug.DrawLine( transform.position, hit.point ); 
			} 
			
		} counter += Time.deltaTime;   
	}
}
