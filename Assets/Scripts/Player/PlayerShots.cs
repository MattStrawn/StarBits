using UnityEngine;
using System.Collections;

public class PlayerShots : MonoBehaviour
{
	public GameObject PlayerBullet;

	void Update()
	{
		if (Input.GetKeyDown("space"))
		{
			Instantiate(PlayerBullet, transform.position, Quaternion.identity);
		}
	}
}
