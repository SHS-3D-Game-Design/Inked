using UnityEngine;
using System.Collections;

public class SMG : MonoBehaviour {
	public float dmg = 20f;
	public GameObject bullets;
	public GameObject[] splash;
	public float delayTime = 1f;
	public GameObject explosionPrefab;
	private float counter = 0;
	public float scaleLimit = 2.0f;    
	public float z = 14f;
	public int count = 40;
	public float length =50;

	void Update () {
		for( int i = 0; i < count; ++i ) {
			FixedUpdate();  
			if(Input.GetKey (KeyCode.Mouse1)){
				scaleLimit = 1f;
				z = 20f;
				length = 75f;
			}
			if(Input.GetKeyUp (KeyCode.Mouse1)){
					scaleLimit = 2.0f;
					z = 14f;
				length = 50f;
				}

		}
		}
	
	void FixedUpdate() {
		if (Input.GetKey (KeyCode.Mouse0) && counter > delayTime) {
			Vector3 direction = Random.insideUnitCircle * scaleLimit;
			direction.z = z; 
			direction = transform.TransformDirection( direction.normalized );  
			counter = 0;
			
			Ray r = new Ray( transform.position, direction);
			RaycastHit hit;     
			if( Physics.Raycast( r, out hit, length) ) {
				Instantiate (splash[Random.Range(0,6)], hit.point, Quaternion.FromToRotation (Vector3.up, hit.normal));
				Instantiate(explosionPrefab, hit.point, Quaternion.FromToRotation (Vector3.up, hit.normal));
				Debug.DrawLine( transform.position, hit.point );
				if(hit.collider.tag == "Enemy"){
					hit.transform.GetComponent<Enemy>().LowerHealth();

						
				
				}
			} 
			
		} counter += Time.deltaTime;   
	}
}



