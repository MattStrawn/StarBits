#pragma strict

public var IncomingMobile : GameObject;
public var MobileSpawnMax : float = 1.0;
public var MobileSpawnMin : float = 0.5;
public var MobileIncoming : float = 1.0;

function Start()
{
	InvokeRepeating("addMobile", MobileIncoming, Random.Range(MobileSpawnMin,MobileSpawnMax));
}

function addMobile()
{  
    var y1 = transform.position.y - GetComponent.<Renderer>().bounds.size.y/2;
    var y2 = transform.position.y + GetComponent.<Renderer>().bounds.size.y/2;

    var spawnPoint = new Vector2(transform.position.x, Random.Range(y1, y2));

    Instantiate(IncomingMobile, spawnPoint, Quaternion.identity);
}