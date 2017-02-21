using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShot : MonoBehaviour {

	public GameObject shot;
	public PolygonCollider2D poly;

	public float speed;
	private float speedScale = 50;
	
	void Start ()
	{
		
	}

	void Update ()
	{
		//tests if shot is off screen
		Vector3 shotPos = new Vector3 (shot.transform.position.x, shot.transform.position.y - .5f, shot.transform.position.z);
		Vector3 tempPos = Camera.main.WorldToScreenPoint(shotPos);
		if (tempPos.y > Screen.height)
		{
			Destroy (shot);
		}

		//moves shot
		shot.transform.Translate (0, speed / speedScale, 0);
	}
}
