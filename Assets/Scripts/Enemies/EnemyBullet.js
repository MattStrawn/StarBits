#pragma strict

public var EnemyBulletSpeed : int = 100;
public var HitEffect : GameObject;

function Start()
{
	GetComponent.<Rigidbody2D>().velocity.x = -EnemyBulletSpeed;
}

function OnTriggerEnter2D(obj : Collider2D)
{  
	var name : String = obj.gameObject.name;
	
	if (name == "Bullets(Clone)")
	{    
		Destroy(gameObject);
		Destroy(obj.gameObject);
		Instantiate (HitEffect, 
			             gameObject.transform.position, Quaternion.identity);
	}
	if (name == "SpawnKiller")
	{
		Destroy(gameObject);
	}
}