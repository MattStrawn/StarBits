using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
	public int FullHealth = 5;
	public int Health;
	public GameObject Player;
	public GameObject DeathEffect;
	public GameObject HitEffect;

	void Start()
	{
		Health = FullHealth;
	}

	void OnTriggerEnter2D(Collider2D obj)
	{  
		string name = obj.gameObject.name;
		
		if (name == "Enemy-Bullets(Clone)")
		{    
			Health--;
			if (Health == 0)
			{
				Destroy(Player);
				Instantiate (DeathEffect, Player.transform.position, Player.transform.rotation);
			}
			Destroy (obj.gameObject);
			Instantiate (HitEffect, 
			             obj.gameObject.transform.position, obj.gameObject.transform.rotation);
		}
	}
}
