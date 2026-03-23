using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class chemistryChaos : MonoBehaviour
{
	private int[][] patternsToFollow = new int[4][];

	private bool gameHasStarted = true;

	private bool teacherTurnHasStarted = true;

	private bool playerTurn;

	private int currentRound;

	public int[] playerInput = new int[3] { -1, -1, -1 };

	public int playerInputNum;

	public int score;

	public int maxPossibleScore;

	[SerializeField]
	private GameObject[] beakers;

	[SerializeField]
	private Slider timer;

	[SerializeField]
	private ClipboardUI clipboardUI;

	[SerializeField]
	private Text command;

	private void Start()
	{
		for (int i = 0; i < patternsToFollow.GetLength(0); i++)
		{
			patternsToFollow[i] = new int[i + 3];
			for (int j = 0; j < patternsToFollow[i].GetLength(0); j++)
			{
				patternsToFollow[i][j] = Random.Range(0, 6);
				maxPossibleScore++;
				Debug.Log(i + ", " + j + ", " + patternsToFollow[i][j] + ", " + patternsToFollow[i].GetLength(0));
			}
		}
	}

	private void Update()
	{
		if ((gameHasStarted && playerTurn && playerInputNum >= currentRound + 2 + 1) || timer.value <= 0f)
		{
			currentRound++;
			playerTurn = false;
			teacherTurnHasStarted = false;
			playerInput = new int[currentRound + 3];
			for (int i = 0; i < playerInput.Length; i++)
			{
				playerInput[i] = -1;
			}
			playerInputNum = 0;
		}
		if (teacherTurnHasStarted && playerTurn)
		{
			timer.value -= 1f * Time.deltaTime;
		}
		if (!playerTurn && !teacherTurnHasStarted && currentRound < 4)
		{
			StartCoroutine(teacherTurn());
		}
		else if (!playerTurn && !teacherTurnHasStarted && currentRound >= 4)
		{
			gameOver();
		}
	}

	private IEnumerator teacherTurn()
	{
		timer.value = 12f;
		greyOutBeakers();
		command.text = "memorize the pattern";
		teacherTurnHasStarted = true;
		yield return new WaitForSeconds(1f);
		for (int i = 0; i < patternsToFollow[currentRound].Length; i++)
		{
			beakers[patternsToFollow[currentRound][i]].GetComponent<Animator>().Play("Bottle_Click");
			yield return new WaitForSeconds(1f);
		}
		playerTurn = true;
		command.text = "replicate the pattern";
		ungreyOutBeakers();
	}

	public void CurrentClickedGameObject(GameObject gameObject)
	{
		if (playerTurn && playerInputNum <= currentRound + 3)
		{
			if (gameObject.name == "BeakerGreen")
			{
				gameObject.GetComponent<Animator>().Play("Bottle_Click");
				playerInput[playerInputNum] = 0;
			}
			else if (gameObject.name == "BeakerBlue")
			{
				gameObject.GetComponent<Animator>().Play("Bottle_Click");
				playerInput[playerInputNum] = 1;
			}
			else if (gameObject.name == "BeakerYellow")
			{
				gameObject.GetComponent<Animator>().Play("Bottle_Click");
				playerInput[playerInputNum] = 2;
			}
			else if (gameObject.name == "BeakerRed")
			{
				gameObject.GetComponent<Animator>().Play("Bottle_Click");
				playerInput[playerInputNum] = 3;
			}
			else if (gameObject.name == "BeakerOrange")
			{
				gameObject.GetComponent<Animator>().Play("Bottle_Click");
				playerInput[playerInputNum] = 4;
			}
			else if (gameObject.name == "BeakerPurple")
			{
				gameObject.GetComponent<Animator>().Play("Bottle_Click");
				playerInput[playerInputNum] = 5;
			}
			if (playerInput[playerInputNum] == patternsToFollow[currentRound][playerInputNum])
			{
				score++;
			}
			playerInputNum++;
		}
	}

	public void gameStarted()
	{
		gameHasStarted = true;
		teacherTurnHasStarted = false;
	}

	public void gameOver()
	{
		if (gameHasStarted)
		{
			gameHasStarted = false;
			teacherTurnHasStarted = true;
			clipboardUI.gameOver();
			clipboardUI.addScore(100 * (score / maxPossibleScore), new int[6] { 5, 0, 0, 0, 0, -5 });
		}
	}

	private void greyOutBeakers()
	{
		for (int i = 0; i < beakers.Length; i++)
		{
			Color color = new Color(255f, 255f, 255f, 0.7f);
			Color color2 = new Color(255f, 255f, 255f, 0.3f);
			beakers[i].GetComponent<SpriteRenderer>().color = color;
			beakers[i].transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().color = color2;
		}
	}

	private void ungreyOutBeakers()
	{
		for (int i = 0; i < beakers.Length; i++)
		{
			Color color = new Color(255f, 255f, 255f, 1f);
			Color color2 = new Color(255f, 255f, 255f, 1f);
			beakers[i].GetComponent<SpriteRenderer>().color = color;
			beakers[i].transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().color = color2;
		}
	}
}
