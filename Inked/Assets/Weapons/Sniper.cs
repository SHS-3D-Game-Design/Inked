using UnityEngine;
using System.Collections;

public class Sniper : MonoBehaviour {
		public GameObject bullets;
		public GameObject splash;
		public float delayTime = 1f;
		public GameObject explosionPrefab;
		private float counter = 0;
		public float scaleLimit = 2.0f;    
		public float z = 30f;
		public int count = 1;

		
		void Update () {
			for( int i = 0; i < count; ++i ) {
				FixedUpdate();    
			}
		}
		
		void FixedUpdate() {
			if (Input.GetMouseButtonDown (0) && counter > delayTime) {
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

		}counter += Time.deltaTime;   
			}  
		
	}
