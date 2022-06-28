using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
	Transform player;
	Vector2 dir;
	Rigidbody2D rb;
	public float speed = 2f;
	int i = 0;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		player = GameObject.Find("Player").transform;
		
	}
	private void Update()
	{
		if (player)
			dir = (player.position - transform.position).normalized;

	}
	
	void FixedUpdate()
	{
		rb.velocity = dir * speed;

		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		
		rb.rotation = angle;
	}
	void repeat()
	{
		Debug.Log("Call " + i);
		i++;
	}

	

	

}
