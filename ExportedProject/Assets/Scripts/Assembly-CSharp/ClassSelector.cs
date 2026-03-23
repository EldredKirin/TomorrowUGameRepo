using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClassSelector : MonoBehaviour
{
	public Dropdown[] classes = new Dropdown[5];

	public Text error;

	public Text coreTxt;

	public Text year;

	private bool err;

	public PlayerStats playerStats;

	public StaticScript staticScript;

	public int[,] reqClasses = new int[14, 3]
	{
		{ 0, 1, 2 },
		{ 0, 1, 2 },
		{ 0, 1, 2 },
		{ 0, 1, 2 },
		{ 0, 1, 2 },
		{ 0, 1, 2 },
		{ 0, 1, 2 },
		{ 0, 1, 2 },
		{ 0, 1, 2 },
		{ 0, 1, 2 },
		{ 0, 1, 2 },
		{ 0, 1, 2 },
		{ 0, 1, 2 },
		{ 0, 1, 2 }
	};

	private int coreMet;

	public Button startButton;

	private void Start()
	{
		for (int i = 0; i < reqClasses.GetLength(1); i++)
		{
			switch (reqClasses[playerStats.getYear(), i])
			{
			case 0:
				coreTxt.text += " Math,";
				break;
			case 1:
				coreTxt.text += " Science,";
				break;
			case 2:
				coreTxt.text += " English,";
				break;
			case 3:
				coreTxt.text += " Gym,";
				break;
			case 4:
				coreTxt.text += " Art,";
				break;
			case 5:
				coreTxt.text += " Speech,";
				break;
			case 6:
				coreTxt.text += " Shop,";
				break;
			case 7:
				coreTxt.text += " Technology,";
				break;
			}
		}
		string text = shortenString(coreTxt.text);
		coreTxt.text = text;
	}

	private string shortenString(string str)
	{
		return str.Substring(0, str.Length - 1);
	}

	private void Update()
	{
		for (int i = 0; i < classes.Length - 1; i++)
		{
			for (int j = i + 1; j < classes.Length; j++)
			{
				if (classes[i].value == classes[j].value)
				{
					err = true;
				}
			}
		}
		if (err)
		{
			error.text = "Classes must all be different!";
			startButton.enabled = false;
		}
		else
		{
			error.text = "";
			startButton.enabled = true;
		}
		for (int k = 0; k < reqClasses.GetLength(1); k++)
		{
			for (int l = 0; l < classes.Length; l++)
			{
				if (reqClasses[playerStats.getYear(), k] == classes[l].value && !err)
				{
					coreMet++;
				}
			}
		}
		if (coreMet == 3 && !err)
		{
			error.text = "";
			startButton.enabled = true;
		}
		else if (!err)
		{
			error.text = "Must meet core requirements for the year:";
			startButton.enabled = false;
		}
		if (coreMet != 3 && !err)
		{
			for (int m = 0; m < reqClasses.GetLength(playerStats.getYear()); m++)
			{
				switch (reqClasses[playerStats.getYear(), m])
				{
				case 0:
					error.text += " Math,";
					break;
				case 1:
					error.text += " Science,";
					break;
				case 2:
					error.text += " English,";
					break;
				case 3:
					error.text += " Gym,";
					break;
				case 4:
					error.text += " Art,";
					break;
				case 5:
					error.text += " Speech,";
					break;
				case 6:
					error.text += " Shop,";
					break;
				case 7:
					error.text += " Technology,";
					break;
				}
			}
			error.text = error.text.Substring(0, error.text.Length - 1);
		}
		err = false;
		coreMet = 0;
	}

	public void finalizeSchedule()
	{
		playerStats.takeSchedule(new int[5]
		{
			classes[0].value,
			classes[1].value,
			classes[2].value,
			classes[3].value,
			classes[4].value
		});
		staticScript.setDestination(1.75f, -0.75f);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void randomizeButton()
	{
		classes[0].value = reqClasses[playerStats.getYear(), 0];
		classes[1].value = reqClasses[playerStats.getYear(), 1];
		classes[2].value = reqClasses[playerStats.getYear(), 2];
		do
		{
			classes[3].value = Random.Range(0, 8);
		}
		while (classes[3].value == classes[0].value || classes[3].value == classes[1].value || classes[3].value == classes[2].value);
		do
		{
			classes[4].value = Random.Range(0, 8);
		}
		while (classes[4].value == classes[0].value || classes[4].value == classes[1].value || classes[4].value == classes[2].value || classes[4].value == classes[3].value);
	}
}
