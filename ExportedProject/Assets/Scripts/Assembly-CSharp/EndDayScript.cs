using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndDayScript : MonoBehaviour
{
	[SerializeField]
	public PlayerStats playerStats;

	private string end;

	[SerializeField]
	public Text endText;

	[SerializeField]
	public Text[] classText;

	[SerializeField]
	public Text[] gradeText;

	private bool initialized;

	[SerializeField]
	private Text averageGrade;

	private void Start()
	{
		if (playerStats.getYear() < 14)
		{
			int num = 0;
			int num2 = 6 + playerStats.getYear() / 2;
			num = ((playerStats.getYear() % 2 == 0) ? 1 : 2);
			end = "Congratulations, you've completed year " + num2 + " and semester " + num + " of grade school";
			endText.text = end;
		}
	}

	private void Update()
	{
		if (initialized)
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < playerStats.classGrades.Length; i++)
		{
			num += playerStats.classGrades[i];
		}
		averageGrade.text = (num / playerStats.classGrades.Length).ToString() ?? "";
		for (int j = 0; j < playerStats.classIDs.Length; j++)
		{
			switch (playerStats.classIDs[j])
			{
			case 0:
				classText[j].text = "Math";
				break;
			case 1:
				classText[j].text = "Science";
				break;
			case 2:
				classText[j].text = "English";
				break;
			case 3:
				classText[j].text = "Gym";
				break;
			case 4:
				classText[j].text = "Art";
				break;
			case 5:
				classText[j].text = "Speech";
				break;
			case 6:
				classText[j].text = "Shop";
				break;
			case 7:
				classText[j].text = "Technology";
				break;
			}
		}
		for (int k = 0; k < playerStats.classGrades.Length; k++)
		{
			gradeText[k].text = playerStats.classGrades[k].ToString() ?? "";
		}
		initialized = true;
	}

	public void nextDay()
	{
		for (int i = 0; i < playerStats.classGrades.Length; i++)
		{
			playerStats.classGrades[i] = 0;
		}
		playerStats.nextYear();
		SceneManager.LoadScene("ScheduleScreen");
	}
}
