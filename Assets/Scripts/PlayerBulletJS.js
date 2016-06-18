#pragma strict

public var BulletSpeed : int = 100;

function Start()
{
	GetComponent.<Rigidbody2D>().velocity.x = BulletSpeed;
}

function OnBecameInvisible()
{
	Destroy(gameObject);
}