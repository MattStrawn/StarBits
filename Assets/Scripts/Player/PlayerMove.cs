using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{

	public float MoveSpeed = 1;
	Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	
	void Update()
	{
		rb.velocity = new Vector2(rb.velocity.x, Input.GetAxis("Vertical") * MoveSpeed);
	}	
}
