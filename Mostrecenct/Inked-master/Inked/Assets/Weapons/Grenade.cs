using UnityEngine;
using System.Collections;

public class Grenade : MonoBehaviour {
	public Rigidbody projectile;
	public Transform shotPos;
	public float shotForce = 1000f;
	public float spawnPeriod = 5f;
	private float nextSpawnTime;
	public float radius;
	public float power;
	public float delay = 2.0;
	
	
	void Start(){
				Vector3 explosionPos = transform.position;
				Collider[] colliders = Physics.OverlapSphere (explosionPos, radius);
				foreach (Collider hit in colliders) {
						Rigidbody rb = hit.GetComponent<Rigidbody> ();
			
						if (rb != null)
								rb.AddExplosionForce (power, explosionPos, radius, 3.0F);
				}
		}
	
	void Update ()
	{
		
		if (Input.GetKeyDown ("e")&& Time.time > nextSpawnTime) {
			
			nextSpawnTime = Time.time + spawnPeriod;
			{
				
				Rigidbody shot = Instantiate (projectile, shotPos.position, shotPos.rotation) as Rigidbody;
				shot.AddForce (shotPos.forward * shotForce);
				
				
			}

		}
	}
	void WaitAndDestroy(){
		yield WaitForSeconds(delay);
		Destroy (gameObject);
	}
}