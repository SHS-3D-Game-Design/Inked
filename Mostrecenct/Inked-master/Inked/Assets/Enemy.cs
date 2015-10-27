using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public int Health = 100;

	// Update is called once per frame
	public void Update () {
		
		if(Health <=0){
			Destroy(this.gameObject);
		}    
	}
	public void LowerHealth()
	{
		Health -= 5;
	}
}