using UnityEngine;
using System.Collections;

public class Asteroids : MonoBehaviour
{
	public float AsteroidSpeed = 1f;
	public float AsteroidFollowMax = 1f;
	public float AsteroidFollowMin = 0.5f;
	public float ExpandRange = 1f;
	public GameObject Player;
	public GameObject ImpactShip;
	public GameObject ImpactBullet;
	
	Vector2 PlayerPos;
	Rigidbody2D rb;
	float follow;
	
	void Awake()
	{
		PlayerPos.y = Player.transform.position.y + 
			Random.Range (ExpandRange,-ExpandRange);
		follow = (PlayerPos.y - gameObject.transform.position.y) * 
			Random.Range (AsteroidFollowMin,AsteroidFollowMax);
	}
	
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	
	void Update()
	{
		rb.velocity = new Vector2 (-AsteroidSpeed, follow);
	}
	
	void OnTriggerEnter2D(Collider2D obj)
	{  
		string name = obj.gameObject.name;
		
		if (name == "Bullets(Clone)")
		{    
			Destroy(obj.gameObject);
			Instantiate (ImpactBullet, 
			             obj.gameObject.transform.position, obj.gameObject.transform.rotation);
		}
		if (name == "EnemyBullets(Clone)")
		{    
			Destroy(obj.gameObject);
			Instantiate (ImpactBullet, 
			            obj.gameObject.transform.position, obj.gameObject.transform.rotation);
		}
		if (name == "Enemy-Mobile(Clone)")
		{    
			Destroy(obj.gameObject);
			Instantiate (ImpactShip, 
			             obj.gameObject.transform.position, obj.gameObject.transform.rotation);
		}
		if (name == "Enemy-Shooter(Clone)")
		{    
			Destroy(obj.gameObject);
			Instantiate (ImpactShip, 
			             obj.gameObject.transform.position, obj.gameObject.transform.rotation);
		}
		if (name == "Ship")
		{
			Destroy(obj.gameObject);
			Instantiate (ImpactShip, 
			             obj.gameObject.transform.position, obj.gameObject.transform.rotation);
		}
		if (name == "SpawnKiller")
		{
			Destroy(gameObject);
		}
	}
}
