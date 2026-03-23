using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StackAttackScript : MonoBehaviour
{
	[SerializeField]
	private ClipboardUI clipboardUI;

	public PlayerStats playerStats;

	[SerializeField]
	private List<GameObject> objQueue;

	private int index;

	private Vector3 mousePos;

	private bool placedAll;

	public float time = 5f;

	[SerializeField]
	private Slider timer;

	[SerializeField]
	private Text finishText;

	private Rigidbody2D rb;

	private bool gameHasStarted;

	private void Start()
	{
		index = 0;
	}

	private void Update()
	{
		if (!placedAll && gameHasStarted)
		{
			mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			mousePos.z = 0f;
			if ((double)mousePos.y < -2.5)
			{
				mousePos.y = -2.5f;
			}
			objQueue[index].transform.position = mousePos;
			rb = objQueue[index].GetComponent<Rigidbody2D>();
			BoxCollider2D boxCollider2D = objQueue[index].GetComponent(typeof(BoxCollider2D)) as BoxCollider2D;
			CircleCollider2D circleCollider2D = objQueue[index].GetComponent(typeof(CircleCollider2D)) as CircleCollider2D;
			rb.freezeRotation = true;
			rb.gravityScale = 0f;
			if (boxCollider2D != null)
			{
				boxCollider2D.isTrigger = true;
			}
			if (circleCollider2D != null)
			{
				circleCollider2D.isTrigger = true;
			}
			if (Input.GetMouseButtonDown(0))
			{
				rb.freezeRotation = false;
				if (boxCollider2D != null)
				{
					boxCollider2D.isTrigger = false;
				}
				if (circleCollider2D != null)
				{
					circleCollider2D.isTrigger = false;
				}
				index++;
				rb.gravityScale = 1f;
			}
		}
		if (index >= objQueue.Count && gameHasStarted)
		{
			placedAll = true;
		}
		if (placedAll && gameHasStarted)
		{
			time -= 1f * Time.deltaTime;
			timer.value = time;
		}
		if (time < 0f && gameHasStarted)
		{
			time = 0f;
			gameWin();
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (gameHasStarted)
		{
			gameLose();
		}
	}

	private void gameWin()
	{
		gameHasStarted = false;
		finishText.text = "You win!";
		clipboardUI.addScore(100, new int[6] { 0, 5, 0, 0, 10, -5 });
		clipboardUI.gameOver();
	}

	private void gameLose()
	{
		int score = (int)(20f * (5f - timer.value));
		clipboardUI.addScore(score, new int[6] { 0, 5, 0, 0, 10, -5 });
		clipboardUI.gameOver();
		finishText.text = "You lose!";
		gameHasStarted = false;
	}

	public void startGame()
	{
		if (!gameHasStarted)
		{
			gameHasStarted = true;
		}
	}
}
