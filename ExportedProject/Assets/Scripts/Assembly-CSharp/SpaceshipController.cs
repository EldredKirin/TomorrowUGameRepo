using System;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
	public float speed = 5f;

	public Projectile laserPrefab;

	private bool laserActive;

	[SerializeField]
	private VirusGrid virusGrid;

	private void Start()
	{
	}

	private void Update()
	{
		if (virusGrid.hasGameStarted)
		{
			if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && base.transform.position.x > -10f)
			{
				base.transform.position += Vector3.left * speed * Time.deltaTime;
			}
			else if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && base.transform.position.x < 10f)
			{
				base.transform.position += Vector3.right * speed * Time.deltaTime;
			}
			if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
			{
				shoot();
			}
		}
	}

	private void shoot()
	{
		if (!laserActive)
		{
			Projectile projectile = UnityEngine.Object.Instantiate(laserPrefab, base.transform.position, Quaternion.identity);
			projectile.destroyed = (Action)Delegate.Combine(projectile.destroyed, new Action(LaserDestroyed));
			laserActive = true;
		}
	}

	private void LaserDestroyed()
	{
		laserActive = false;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.layer == LayerMask.NameToLayer("Virus") || other.gameObject.layer == LayerMask.NameToLayer("Missile"))
		{
			virusGrid.gameOver();
		}
	}
}
