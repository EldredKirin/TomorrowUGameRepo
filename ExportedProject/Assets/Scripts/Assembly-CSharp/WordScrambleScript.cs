using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class WordScrambleScript : MonoBehaviour
{
	[SerializeField]
	public WordScrambleLetter[] wordScrambleLetter = new WordScrambleLetter[8];

	[SerializeField]
	public WordScrambleSlot[] wordScrambleSlot = new WordScrambleSlot[8];

	public List<string> dict = new List<string>();

	public List<string> alreadyMade = new List<string>();

	private bool isInvalid = true;

	private string[] selectWords = new string[5] { "notebook", "artistic", "fairness", "alphabet", "hopeless" };

	private string selectedWord = "bazingas";

	public string currentWord;

	public int letterCount;

	public int points;

	public Text pointText;

	public GameObject startButton;

	public bool gameHasStarted;

	public Slider timeRemaining;

	public Text doneWords;

	[SerializeField]
	private ClipboardUI clipboardUI;

	public Vector2 mousePos;

	private void Start()
	{
		string[] array = File.ReadAllLines("Assets/words.txt");
		for (int i = 0; i < array.Length; i++)
		{
			dict.Add(array[i]);
		}
		selectedWord = selectWords[(int)Random.Range(0f, selectWords.Length)];
		for (int j = 0; j < 8; j++)
		{
			wordScrambleLetter[j].setLetter(selectedWord.Substring(j, 1));
			wordScrambleLetter[j].index = j;
		}
		for (int k = 0; k < 8; k++)
		{
			wordScrambleSlot[k].index = k;
		}
	}

	private void Update()
	{
		mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		compileWord();
		if (gameHasStarted)
		{
			timeRemaining.value -= 1f * Time.deltaTime;
		}
		pointText.text = "Score: " + points;
		if (gameHasStarted && timeRemaining.value <= 0f)
		{
			gameHasStarted = false;
			gameEnd();
		}
	}

	public void compileWord()
	{
		currentWord = null;
		for (int i = 0; i < 8; i++)
		{
			currentWord += wordScrambleSlot[i].letter;
		}
	}

	public void check()
	{
		if (currentWord.Length > 2 && currentWord.Length < 9 && gameHasStarted)
		{
			Debug.Log("A");
			for (int i = 0; i < dict.Count; i++)
			{
				if (!currentWord.Equals(dict[i]))
				{
					continue;
				}
				Debug.Log("B");
				isInvalid = false;
				for (int j = 0; j < alreadyMade.Count; j++)
				{
					if (currentWord.Equals(alreadyMade[j]))
					{
						Debug.Log("C");
						isInvalid = true;
					}
				}
			}
		}
		if (!isInvalid)
		{
			isInvalid = true;
			Debug.Log("D");
			points++;
			alreadyMade.Add(currentWord);
			doneWords.text = doneWords.text + currentWord + " ";
			backspace(0);
		}
	}

	public Vector2 sendMousePoint()
	{
		return mousePos;
	}

	public void backspace(int index)
	{
		for (int i = 0; i < 8; i++)
		{
			if (wordScrambleSlot[i].wordScrambleLetter != null)
			{
				wordScrambleSlot[i].wordScrambleLetter.detatch();
			}
			wordScrambleSlot[i].wordScrambleLetter = null;
			wordScrambleSlot[i].letter = "";
			letterCount = 0;
			currentWord = null;
		}
		currentWord = "";
	}

	public void startGame()
	{
		if (!gameHasStarted)
		{
			gameHasStarted = true;
			startButton.SetActive(value: false);
		}
	}

	private void gameEnd()
	{
		clipboardUI.addScore(points * 10, new int[6] { 0, 0, 3, 1, 0, -10 });
		clipboardUI.gameOver();
	}
}
