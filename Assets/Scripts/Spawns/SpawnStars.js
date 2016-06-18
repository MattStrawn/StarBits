#pragma strict

public var IncomingStar : GameObject;
public var StarSpawn : float = 1.0;

function Start()
{
	InvokeRepeating("addStar", StarSpawn, StarSpawn);
}

function addStar()
{  
    var y1 = transform.position.y - GetComponent.<Renderer>().bounds.size.y/2;
    var y2 = transform.position.y + GetComponent.<Renderer>().bounds.size.y/2;

    var spawnPoint = new Vector2(transform.position.x, Random.Range(y1, y2));

    Instantiate(IncomingStar, spawnPoint, Quaternion.identity);
}