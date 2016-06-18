using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour
{
	public int EnemyHealth = 1;
	public float EnemySpeed = 1f;
	public float EnemyFollowMax = 1f;
	public float EnemyFollowMin = 0.5f;
	public float ExpandRange = 1f;
	public GameObject Player;
	public GameObject EnemyDeath;
	public GameObject PlayerDeath;
	
	Vector2 PlayerPos;
	Rigidbody2D rb;
	float follow;

	void Awake()
	{
		PlayerPos.y = Player.transform.position.y + 
			Random.Range (ExpandRange,-ExpandRange);
		follow = (PlayerPos.y - gameObject.transform.position.y) * 
			Random.Range (EnemyFollowMin,EnemyFollowMax);
	}

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	
	void Update()
	{
		rb.velocity = new Vector2 (-EnemySpeed, follow);
	}
	
	void OnTriggerEnter2D(Collider2D obj)
	{  
		string name = obj.gameObject.name;
		
		if (name == "Bullets(Clone)")
		{    
			EnemyHealth--;
			
			if (EnemyHealth == 0)
			{
				Destroy(gameObject);
				Instantiate (EnemyDeath, 
				             gameObject.transform.position, gameObject.transform.rotation);
			}
			Destroy(obj.gameObject);
		}
		if (name == "Ship")
		{
			Destroy(gameObject);
			Destroy(obj.gameObject);
			Instantiate (EnemyDeath, 
			             gameObject.transform.position, gameObject.transform.rotation);
			Instantiate (PlayerDeath, 
			             obj.gameObject.transform.position, obj.gameObject.transform.rotation);
		}
		if (name == "SpawnKiller")
		{
			Destroy(gameObject);
		}
	}
}