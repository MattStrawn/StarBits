#pragma strict

public var IncomingShooter : GameObject;
public var ShooterSpawnMax : float = 1.0;
public var ShooterSpawnMin : float = 0.5;
public var ShooterIncoming : float = 1.0;

function Start()
{
	InvokeRepeating("addShooter", ShooterIncoming, Random.Range(ShooterSpawnMin,ShooterSpawnMax));
}

function addShooter()
{
	var y1 = transform.position.y - GetComponent.<Renderer>().bounds.size.y/2;
	var y2 = transform.position.y + GetComponent.<Renderer>().bounds.size.y/2;
	
	var spawnPoint = new Vector2(transform.position.x, Random.Range(y1, y2));
	
	Instantiate(IncomingShooter, spawnPoint, Quaternion.identity);
}