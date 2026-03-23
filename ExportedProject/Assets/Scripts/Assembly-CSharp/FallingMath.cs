using UnityEngine;
using UnityEngine.UI;

public class FallingMath : MonoBehaviour
{
	public int term1;

	public int term2;

	public int oper;

	public int answer;

	public int answerRNG;

	public int answerRNG1;

	public int answerRNG2;

	public Camera cam;

	public float fallFactor;

	public float height;

	public float time = 60f;

	public bool hasGameStarted;

	public int score;

	public float fallingSpeed = 50f;

	public Transform text;

	public Transform canvas;

	public Text equation;

	public Text answer1;

	public Text answer2;

	public Text answer3;

	public Text scoreCounter;

	public Text finishText;

	public Slider timer;

	public GameObject light1;

	public GameObject light2;

	public GameObject light3;

	public GameObject startButton;

	[SerializeField]
	private PlayerStats playerStats;

	[SerializeField]
	private ClipboardUI clipboardUI;

	private void Start()
	{
		text.transform.position = canvas.transform.position + new Vector3(0f, 500f, 0f);
	}

	private void Update()
	{
		if (score < 0)
		{
			score = 0;
		}
		height = cam.pixelHeight;
		fallFactor = height / 1080f;
		if (hasGameStarted)
		{
			text.transform.position = text.transform.position + new Vector3(0f, fallFactor * (0f - fallingSpeed) * Time.deltaTime, 0f);
			time -= 1f * Time.deltaTime;
			timer.value = time;
			finishText.text = "";
		}
		if (text.transform.position.y < canvas.transform.position.y + -140f * fallFactor)
		{
			fallingSpeed = 0f;
			hasGameStarted = false;
			equation.text = "Game Over!";
			gameLose();
		}
		if (time < 0f)
		{
			fallingSpeed = 0f;
			hasGameStarted = false;
			equation.text = "Game Over!";
			gameLose();
		}
		if (score == 0 && hasGameStarted)
		{
			light1.SetActive(value: false);
			light2.SetActive(value: false);
			light3.SetActive(value: false);
		}
		else if (score == 1 && hasGameStarted)
		{
			light1.SetActive(value: true);
			light2.SetActive(value: false);
			light3.SetActive(value: false);
		}
		else if (score == 2 && hasGameStarted)
		{
			light1.SetActive(value: true);
			light2.SetActive(value: true);
			light3.SetActive(value: false);
		}
		else if (score == 3 && hasGameStarted)
		{
			light1.SetActive(value: true);
			light2.SetActive(value: true);
			light3.SetActive(value: true);
			gameWin();
		}
	}

	public void EquationGenerate()
	{
		oper = Random.Range(0, 4);
		if (oper == 0)
		{
			term1 = Random.Range(1, 30);
			term2 = Random.Range(1, 30);
			answer = term1 + term2;
			equation.text = term1 + " + " + term2 + " =";
		}
		else if (oper == 1)
		{
			term1 = Random.Range(1, 60);
			term2 = Random.Range(1, term1);
			answer = term1 - term2;
			equation.text = term1 + " - " + term2 + " =";
		}
		else if (oper == 2)
		{
			term1 = Random.Range(1, 13);
			term2 = Random.Range(1, 13);
			answer = term1 * term2;
			equation.text = term1 + " * " + term2 + " =";
		}
		if (oper == 3)
		{
			term1 = Random.Range(1, 13);
			term2 = Random.Range(1, 13);
			term1 *= term2;
			answer = term1 / term2;
			equation.text = term1 + " % " + term2 + " =";
		}
		answerRNG = Random.Range(0, 3);
		if (answerRNG == 0)
		{
			answer1.text = answer.ToString() ?? "";
			answerRNG1 = Random.Range(1, 30);
			if (answerRNG1 == answer)
			{
				answerRNG1++;
			}
			answerRNG2 = Random.Range(30, 60);
			if (answerRNG2 == answer)
			{
				answerRNG2--;
			}
			answer2.text = answerRNG1.ToString() ?? "";
			answer3.text = answerRNG2.ToString() ?? "";
		}
		if (answerRNG == 1)
		{
			answer2.text = answer.ToString() ?? "";
			answerRNG1 = Random.Range(1, 30);
			if (answerRNG1 == answer)
			{
				answerRNG1++;
			}
			answerRNG2 = Random.Range(30, 60);
			if (answerRNG2 == answer)
			{
				answerRNG2--;
			}
			answer1.text = answerRNG2.ToString() ?? "";
			answer3.text = answerRNG1.ToString() ?? "";
		}
		if (answerRNG == 2)
		{
			answer3.text = answer.ToString() ?? "";
			answerRNG1 = Random.Range(1, 30);
			if (answerRNG1 == answer)
			{
				answerRNG1++;
			}
			answerRNG2 = Random.Range(30, 60);
			if (answerRNG2 == answer)
			{
				answerRNG2--;
			}
			answer2.text = answerRNG1.ToString() ?? "";
			answer1.text = answerRNG2.ToString() ?? "";
		}
		text.transform.position = new Vector3(canvas.transform.position.x, scoreCounter.transform.position.y + 100f * fallFactor, 0f);
	}

	public void checkAnswer(int button)
	{
		if (time > 0f)
		{
			if (button == answerRNG)
			{
				EquationGenerate();
				score++;
				scoreCounter.text = "Score: " + score;
			}
			else
			{
				EquationGenerate();
				score--;
				scoreCounter.text = "Score: " + score;
			}
		}
	}

	public void startGame()
	{
		if (!hasGameStarted)
		{
			hasGameStarted = true;
			EquationGenerate();
		}
	}

	public void gameWin()
	{
		int num = 0;
		num = ((time > 30f) ? 100 : ((time > 20f) ? 90 : ((!(time > 10f)) ? 70 : 80)));
		hasGameStarted = false;
		finishText.text = "You win!";
		clipboardUI.addScore(num, new int[6] { 5, 0, 0, 0, 0, -5 });
		clipboardUI.gameOver();
	}

	public void gameLose()
	{
		int num = 0;
		num = ((score == 2) ? 60 : ((score == 1) ? 30 : 0));
		hasGameStarted = false;
		finishText.text = "You lose!";
		clipboardUI.addScore(num, new int[6] { 0, 5, 0, 0, 0, -5 });
		clipboardUI.gameOver();
	}
}
