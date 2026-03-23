using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClipboardUI : MonoBehaviour
{
	[SerializeField]
	private GameObject startButton;

	[SerializeField]
	private GameObject helpButton;

	[SerializeField]
	private GameObject closeHelpButton;

	[SerializeField]
	private GameObject continueButton;

	[SerializeField]
	private Animator startAnimate;

	[SerializeField]
	private GameObject screen1;

	[SerializeField]
	private GameObject screen2;

	[SerializeField]
	private Text gradeText;

	[SerializeField]
	private PlayerStats playerStats;

	[SerializeField]
	private string newLevel;

	[SerializeField]
	private float destinationX;

	[SerializeField]
	private float destinationY;

	[SerializeField]
	private StaticScript staticScript;

	private int classSlot;

	private void Start()
	{
	}

	public void gameStart()
	{
		startAnimate.SetBool("GameStarted", value: true);
	}

	public void gameOver()
	{
		startAnimate.SetBool("GameStarted", value: false);
		startAnimate.SetBool("GameOver", value: true);
		startButton.SetActive(value: false);
		continueButton.SetActive(value: true);
		helpButton.SetActive(value: false);
	}

	public void addScore(int score, int[] statMod)
	{
		classSlot = playerStats.getTimeOfDay() - 8;
		if (classSlot == 3)
		{
			classSlot = -1;
		}
		else if (classSlot == 4)
		{
			classSlot = -2;
		}
		else if (classSlot == 5)
		{
			classSlot = 3;
		}
		else if (classSlot == 6)
		{
			classSlot = 4;
		}
		else if (classSlot > 6)
		{
			classSlot = 0;
		}
		Debug.Log(classSlot.ToString());
		playerStats.modStem(statMod[0]);
		playerStats.modAth(statMod[1]);
		playerStats.modArt(statMod[2]);
		playerStats.modCha(statMod[3]);
		playerStats.modHealth(statMod[4]);
		playerStats.modStress(statMod[5]);
		if (score > 90)
		{
			startAnimate.SetFloat("Grade", 4f);
		}
		else if (score > 80)
		{
			startAnimate.SetFloat("Grade", 3f);
		}
		else if (score > 70)
		{
			startAnimate.SetFloat("Grade", 2f);
		}
		else if (score > 60)
		{
			startAnimate.SetFloat("Grade", 1f);
		}
		else
		{
			startAnimate.SetFloat("Grade", 0f);
		}
		if (classSlot >= 0)
		{
			playerStats.classGrades[classSlot] = score;
		}
		gradeText.text = score.ToString() ?? "";
		playerStats.writeStats();
		playerStats.modTime(1);
	}

	public void openHelp()
	{
		screen1.SetActive(value: false);
		screen2.SetActive(value: true);
		helpButton.SetActive(value: false);
		closeHelpButton.SetActive(value: true);
	}

	public void closeHelp()
	{
		screen1.SetActive(value: true);
		screen2.SetActive(value: false);
		helpButton.SetActive(value: true);
		closeHelpButton.SetActive(value: false);
	}

	public void returnToGame()
	{
		if (staticScript.getNewScene() != null)
		{
			SceneManager.LoadScene(staticScript.getNewScene());
		}
		else
		{
			SceneManager.LoadScene(newLevel);
		}
	}
}
