using UnityEngine;
using System.Collections;

public class ExtraMoves : MonoBehaviour {

	public float walkSpeed = 8; // regular speed
	public float crchSpeed = 3; // crouching speed
	public float runSpeed = 20; // run speed
	
	private CharacterMotor chMotor;
	private Transform tr; // distance to ground
	
	// Use this for initialization
	void Start () 
	{
		chMotor =  GetComponent<CharacterMotor>();

	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		float speed = walkSpeed;
		
		if ((Input.GetKey("left shift") || Input.GetKey("right shift")) && chMotor.grounded)
		{
			speed = runSpeed;            
		}
		
		if (Input.GetKey("c"))
		{ // press C to crouch

			speed = crchSpeed; // slow down when crouching
		}
		
		chMotor.movement.maxForwardSpeed = speed; // set max speed
		float ultScale = tr.localScale.y; // crouch/stand up smoothly 
		
		Vector3 tmpScale = tr.localScale;
		Vector3 tmpPosition = tr.position;

		tr.localScale = tmpScale;
		

	}
}
