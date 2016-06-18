#pragma strict

public var IncomingAsteroid1 : GameObject;
public var IncomingAsteroid2 : GameObject;
public var IncomingAsteroid3 : GameObject;
public var AsteroidSpawnMax : float = 1.0;
public var AsteroidSpawnMin : float = 0.5;
public var AsteroidIncoming : float = 1.0;

var RandomAsteroid : GameObject;

function Start()
{
	InvokeRepeating("addAsteroid", AsteroidIncoming, Random.Range(AsteroidSpawnMin,AsteroidSpawnMax));
}

function addAsteroid()
{  
    var y1 = transform.position.y - GetComponent.<Renderer>().bounds.size.y/2;
    var y2 = transform.position.y + GetComponent.<Renderer>().bounds.size.y/2;

    var spawnPoint = new Vector2(transform.position.x, Random.Range(y1, y2));

    Instantiate(RandomAsteroid, spawnPoint, Quaternion.identity);
}

function Update()
{
	var AstSelect : int = Random.Range(1,3);
	
	if (AstSelect == 1)
	{
		RandomAsteroid = IncomingAsteroid1;
	}
	else if (AstSelect == 2)
	{
		RandomAsteroid = IncomingAsteroid2;
	}
	else if (AstSelect == 3)
	{
		RandomAsteroid = IncomingAsteroid3;
	}
}