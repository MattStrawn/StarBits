using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

	public int MoveSpeed = 1;
	public GameObject PlayerBullet;

	Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		rb.velocity = new Vector2(rb.velocity.x, Input.GetAxis("Vertical") * MoveSpeed);

		
		if (Input.GetKeyDown("space"))
		{
			Instantiate(PlayerBullet, transform.position, Quaternion.identity);
		}
	}	
}
