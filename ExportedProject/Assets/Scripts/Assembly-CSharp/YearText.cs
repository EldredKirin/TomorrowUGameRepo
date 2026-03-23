using UnityEngine;
using UnityEngine.UI;

public class YearText : MonoBehaviour
{
	[SerializeField]
	public PlayerStats playerStats;

	private string yearText;

	[SerializeField]
	public Text text;

	private void Start()
	{
	}

	private void Update()
	{
		int num = 6 + playerStats.getYear() / 2;
		int num2 = playerStats.getYear() % 2 + 1;
		yearText = "SELECT CLASSES FOR YOUR " + num + "th GRADE YEAR " + num2 + " SEMESTER";
		text.text = yearText;
	}
}
