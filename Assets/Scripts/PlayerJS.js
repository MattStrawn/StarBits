#pragma strict

public var MoveSpeed : int = 1;
public var PlayerBullet : GameObject;

function Update()
{
	GetComponent.<Rigidbody2D>().velocity.y = Input.GetAxis("Vertical")*MoveSpeed;
	
	if (Input.GetKeyDown("space"))
	{
		Instantiate(PlayerBullet, transform.position, Quaternion.identity);
	}
}