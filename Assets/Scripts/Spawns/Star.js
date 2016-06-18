#pragma strict

public var StarSpeed : float = 1.0;

function Start()
{
	GetComponent.<Rigidbody2D>().velocity.x = -StarSpeed;
}

function Update()
{

}

function OnTriggerEnter2D(obj : Collider2D)
{  
    var name = obj.gameObject.name;

    if (name == "SpawnKiller")
    {
        Destroy(gameObject);
    }
}