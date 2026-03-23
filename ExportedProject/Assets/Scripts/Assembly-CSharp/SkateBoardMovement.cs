using System;
using UnityEngine;
using UnityEngine.UI;

public class SkateBoardMovement : MonoBehaviour
{
	public PlayerStats playerStats;

	public float acceleration = 10f;

	public float turnSpeed = 3.5f;

	public float accelerationInput;

	public float steeringInput;

	private float rotationAngle;

	public Rigidbody2D board;

	private float wallRecoveryTime = 1f;

	public float timer = 60f;

	public float time = 3f;

	public int items;

	public Slider timeSlider;

	public Text collection;

	public Text results;

	public bool hasGameStarted;

	public bool buttonPressed;

	public bool playerWon;

	[SerializeField]
	private ClipboardUI clipboardUI;

	private void Update()
	{
		if (hasGameStarted)
		{
			Vector2 zero = Vector2.zero;
			zero.x = Input.GetAxisRaw("Horizontal");
			zero.y = Input.GetAxisRaw("Vertical");
			steeringInput = zero.x;
			accelerationInput += zero.y * 1.2f * Time.deltaTime;
			if (accelerationInput > 2f)
			{
				accelerationInput = 2f;
			}
			else if (accelerationInput < -2f)
			{
				accelerationInput = -2f;
			}
			if (Input.GetAxis("Vertical") == 0f || Math.Abs(Input.GetAxis("Vertical") - accelerationInput) > 2f)
			{
				accelerationInput -= accelerationInput * (0.8f * Time.deltaTime);
			}
			if ((((double)accelerationInput < 0.1 && accelerationInput > 0f) || ((double)accelerationInput > -0.1 && accelerationInput < 0f)) && Input.GetAxis("Vertical") == 0f)
			{
				accelerationInput = 0f;
			}
			if (wallRecoveryTime < 1f)
			{
				wallRecoveryTime += 0.5f * Time.deltaTime;
			}
			timer -= 1f * Time.deltaTime;
			timeSlider.value = timer;
			if (time > -1f)
			{
				results.text = "GO!";
			}
			else
			{
				results.text = "";
			}
			collection.text = items + "/10 Collected";
			if (items == 10)
			{
				gameWin();
			}
			if (timer < 0f)
			{
				gameLose();
			}
		}
		if (buttonPressed && time >= -1f)
		{
			time -= 1f * Time.deltaTime;
		}
		if (buttonPressed && !hasGameStarted)
		{
			if (time > 0f)
			{
				results.text = ((int)time + 1).ToString() ?? "";
			}
			else if (time > -1f)
			{
				results.text = "GO!";
				hasGameStarted = true;
				clipboardUI.gameStart();
			}
		}
	}

	private void gameWin()
	{
		accelerationInput = 0f;
		turnSpeed = 0f;
		results.text = "You Win!";
		hasGameStarted = false;
		playerWon = true;
		clipboardUI.gameOver();
		clipboardUI.addScore(items * 10, new int[6] { 0, 3, 0, 5, 5, 5 });
	}

	private void gameLose()
	{
		accelerationInput = 0f;
		turnSpeed = 0f;
		results.text = "Game Over!";
		hasGameStarted = false;
		clipboardUI.gameOver();
	}

	private void FixedUpdate()
	{
		AccelerationForce();
		turnInput();
	}

	private void AccelerationForce()
	{
		Vector2 vector = acceleration * accelerationInput * base.transform.up;
		board.MovePosition(board.position + vector * Time.deltaTime);
	}

	private void turnInput()
	{
		rotationAngle -= steeringInput * (turnSpeed * wallRecoveryTime) / (0.3f + Math.Abs(0.4f * accelerationInput));
		board.MoveRotation(rotationAngle);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		accelerationInput /= 10f;
		wallRecoveryTime = 0.5f;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		items++;
		if (collision.gameObject.CompareTag("Collectable"))
		{
			UnityEngine.Object.Destroy(collision.gameObject);
		}
	}

	public void GameStart()
	{
		buttonPressed = true;
	}
}
