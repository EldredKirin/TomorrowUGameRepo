using System;
using UnityEngine;

public class VirusGrid : MonoBehaviour
{
	public VirusAnimations[] prefabs;

	public int rows = 5;

	public int columns = 11;

	public AnimationCurve speed;

	private Vector3 direction = Vector2.right;

	public Projectile missilePrefab;

	public int amountAlive;

	public float missileAttackRate = 1f;

	[SerializeField]
	private ClipboardUI clipboardUI;

	[SerializeField]
	private SpaceshipController spaceshipController;

	public bool hasGameStarted;

	public int amountKilled { get; private set; }

	public int totalViruses => rows * columns;

	public float percentKilled => (float)amountKilled / (float)totalViruses;

	private void Awake()
	{
		for (int i = 0; i < rows; i++)
		{
			float num = 1.4f * (float)(columns - 1);
			float num2 = 1f * (float)(rows - 1);
			Vector2 vector = new Vector2((0f - num) / 2f, (0f - num2) / 2f);
			Vector3 vector2 = new Vector3(vector.x, vector.y + (float)i * 1f, 0f);
			for (int j = 0; j < columns; j++)
			{
				VirusAnimations virusAnimations = UnityEngine.Object.Instantiate(prefabs[i], base.transform);
				virusAnimations.killed = (Action)Delegate.Combine(virusAnimations.killed, new Action(virusKilled));
				Vector3 localPosition = vector2;
				localPosition.x += (float)j * 1.4f;
				virusAnimations.transform.localPosition = localPosition;
			}
		}
	}

	private void Start()
	{
		amountAlive = totalViruses - amountKilled;
		InvokeRepeating("missileAttack", missileAttackRate, missileAttackRate);
	}

	private void Update()
	{
		if (!hasGameStarted)
		{
			return;
		}
		base.transform.position += direction * speed.Evaluate(percentKilled) * Time.deltaTime;
		Camera.main.ViewportToWorldPoint(Vector3.zero);
		Camera.main.ViewportToWorldPoint(Vector3.right);
		foreach (Transform item in base.transform)
		{
			if (item.gameObject.activeInHierarchy)
			{
				if (direction == Vector3.right && item.position.x >= 10f)
				{
					advanceRow();
				}
				else if (direction == Vector3.left && item.position.x <= -10f)
				{
					advanceRow();
				}
			}
		}
	}

	private void advanceRow()
	{
		direction.x *= -1f;
		Vector3 position = base.transform.position;
		position.y -= 0.45f;
		base.transform.position = position;
	}

	private void virusKilled()
	{
		amountKilled++;
		if (amountKilled >= totalViruses)
		{
			gameOver();
		}
	}

	private void missileAttack()
	{
		if (!hasGameStarted)
		{
			return;
		}
		foreach (Transform item in base.transform)
		{
			if (item.gameObject.activeInHierarchy && UnityEngine.Random.value < 1f / (float)amountAlive)
			{
				UnityEngine.Object.Instantiate(missilePrefab, item.position, Quaternion.identity);
				break;
			}
		}
	}

	public void gameStart()
	{
		hasGameStarted = true;
	}

	public void gameOver()
	{
		hasGameStarted = false;
		clipboardUI.gameOver();
		clipboardUI.addScore((int)(percentKilled * 100f), new int[6] { 5, 0, 0, 0, -5, 0 });
	}
}
