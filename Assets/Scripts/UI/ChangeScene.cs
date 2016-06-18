using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour
{
	public void NewScene (string Scene)
	{
			Application.LoadLevel (Scene);
	}
}
