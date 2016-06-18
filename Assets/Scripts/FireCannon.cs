using UnityEngine;
using System.Collections;

public class FireCannon : MonoBehaviour 
{
	// Public variables
	public float forceMultiplier = 200f;
	
	// Object being thrown
	public Rigidbody2D ballRigidbody;

	void Update()
	{
		if ( Input.GetButtonDown("Fire1"))
		{
			Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			mouseWorldPosition.z = 0f;
			
			Vector3 throwVector = mouseWorldPosition - transform.position;
			
			Rigidbody2D ballClone;
			ballClone = Instantiate(ballRigidbody, transform.position, Quaternion.identity) as Rigidbody2D;
			ballClone.AddForce(throwVector * forceMultiplier);
			Destroy(ballClone.gameObject, 1f);
		}
	}
}
