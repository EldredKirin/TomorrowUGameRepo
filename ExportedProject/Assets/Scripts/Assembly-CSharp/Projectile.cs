using System;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	public Vector3 direction;

	public float speed;

	public Action destroyed;

	private void Update()
	{
		base.transform.position += direction * speed * Time.deltaTime;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (destroyed != null)
		{
			destroyed();
		}
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
