#pragma strict

public var EnemyBullets : GameObject;

public var FireRate : float = 1.0;

function Start()
{
	InvokeRepeating("fireAway", FireRate, FireRate);
}

function fireAway()
{
	var spawnPoint = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
	
    Instantiate(EnemyBullets, spawnPoint, Quaternion.identity);
}

function Update()
{

}