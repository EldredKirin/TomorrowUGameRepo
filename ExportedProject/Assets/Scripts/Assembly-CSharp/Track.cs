using UnityEngine;
using UnityEngine.UI;

public class Track : MonoBehaviour
{
	[SerializeField]
	private PlayerStats playerStats;

	[SerializeField]
	private DayNightBehaviour dayNightBehaviour;

	public float speed;

	public float time = 3f;

	public float timeBetweenStrokes;

	public float distance = 200f;

	public float lastKey;

	public float currKey;

	public bool hasGameStarted;

	public bool buttonPressed;

	public bool PlayerWin;

	public int currentTime;

	public float playerStartPosition;

	public float playerEnding;

	public float playerPosition;

	public Transform playerTransform;

	public Transform opponent;

	public float opponentPosition;

	public float enemyDistance = 200f;

	public Slider distanceLeft;

	public Slider spd;

	public Slider enemyDistanceLeft;

	public Text mph;

	public Text yardsLeft;

	public Text enemyYardsLeft;

	public Text results;

	public ClipboardUI clipboardUI;

	private void Start()
	{
		playerTransform = GetComponent<Transform>();
		playerStartPosition = playerTransform.position.x;
		playerEnding = Mathf.Abs(playerStartPosition);
		playerPosition = playerStartPosition;
	}

	private void Update()
	{
		if (hasGameStarted)
		{
			if (Input.GetKeyDown("right") || Input.GetKeyDown("d"))
			{
				Debug.Log("right");
				currKey = 1f;
			}
			else if (Input.GetKeyDown("left") || Input.GetKeyDown("a"))
			{
				Debug.Log("left");
				currKey = -1f;
			}
			if (Input.GetKeyDown("right") || Input.GetKeyDown("left") || ((Input.GetKeyDown("a") || Input.GetKeyDown("d")) && currKey != lastKey))
			{
				if (timeBetweenStrokes > 0f && (double)timeBetweenStrokes <= 0.1)
				{
					speed += 0.3f + (float)playerStats.getAth() * 0.004f;
				}
				else if ((double)timeBetweenStrokes > 0.1 && (double)timeBetweenStrokes <= 0.15)
				{
					speed += 0.15f + (float)playerStats.getAth() * 0.002f;
				}
				else if ((double)timeBetweenStrokes > 0.15 && (double)timeBetweenStrokes <= 0.25)
				{
					speed += 0.05f + (float)playerStats.getAth() * 0.001f;
				}
				else if ((double)timeBetweenStrokes > 0.25)
				{
					speed += 0.03f + (float)playerStats.getAth() * 0.0005f;
				}
				if (Input.GetKeyDown("right") || Input.GetKeyDown("d"))
				{
					lastKey = 1f;
				}
				else if (Input.GetKeyDown("left") || Input.GetKeyDown("a"))
				{
					lastKey = -1f;
				}
				timeBetweenStrokes = 0f;
			}
			if (speed > 0f)
			{
				speed -= 2f * Time.deltaTime;
			}
			timeBetweenStrokes += 1f * Time.deltaTime;
			if (speed > 10f)
			{
				speed = 10f;
			}
			distance -= speed * Time.deltaTime;
			if (distance < 0f)
			{
				distance = 0f;
			}
			if (enemyDistance < 0f)
			{
				enemyDistance = 0f;
			}
			enemyDistance -= 7f * Time.deltaTime;
			if (time > -1f)
			{
				results.text = "GO!";
			}
			else
			{
				results.text = "";
			}
			mph.text = (int)speed + " m/h";
			yardsLeft.text = ((int)distance / 2).ToString() ?? "";
			enemyYardsLeft.text = ((int)enemyDistance / 2).ToString() ?? "";
			spd.value = speed;
			distanceLeft.value = 200f - distance;
			enemyDistanceLeft.value = 200f - enemyDistance;
			if (distance <= 0f && enemyDistance > 0f)
			{
				gameFinish();
			}
			if (distance > 0f && enemyDistance <= 0f)
			{
				gameLose();
			}
			playerPosition = playerStartPosition + (200f - distance) / 200f * (Mathf.Abs(playerStartPosition) + Mathf.Abs(playerEnding));
			base.transform.position = new Vector3(playerPosition, -0.15f, -1.59f);
			opponentPosition = playerStartPosition + (200f - enemyDistance) / 200f * (Mathf.Abs(playerStartPosition) + Mathf.Abs(playerEnding));
			opponent.position = new Vector3(opponentPosition, 0.35f, -1.47f);
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
			}
		}
	}

	public void startGame()
	{
		buttonPressed = true;
		clipboardUI.gameStart();
	}

	public void gameFinish()
	{
		results.text = "FINISH! \n You Win!";
		Debug.Log(distanceLeft.value);
		Debug.Log(enemyDistanceLeft.value);
		int num = (int)((distanceLeft.value - enemyDistanceLeft.value) * 2f);
		if (num > 100)
		{
			num = 100;
		}
		buttonPressed = false;
		hasGameStarted = false;
		PlayerWin = true;
		clipboardUI.addScore(num, new int[6] { 0, 5, 0, 0, 10, -5 });
		clipboardUI.gameOver();
	}

	public void gameLose()
	{
		results.text = "FINISH! \n You Lose!";
		buttonPressed = false;
		hasGameStarted = false;
		clipboardUI.addScore(0, new int[6] { 0, 5, 0, 0, 10, -5 });
		clipboardUI.gameOver();
	}
}
