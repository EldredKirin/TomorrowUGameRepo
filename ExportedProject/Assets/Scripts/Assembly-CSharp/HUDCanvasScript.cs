using UnityEngine;
using UnityEngine.UI;

public class HUDCanvasScript : MonoBehaviour
{
	[SerializeField]
	public Text area;

	[SerializeField]
	public string areaString;

	[SerializeField]
	public Text clock;

	[SerializeField]
	public PlayerStats playerStats;

	private bool isAm;

	private void Start()
	{
		area.text = areaString;
		clock.text = playerStats.getTimeOfDay() + ":00";
	}

	private void Update()
	{
		int num = playerStats.getTimeOfDay();
		if (num < 12)
		{
			isAm = true;
		}
		else if (num > 12 && num < 24)
		{
			isAm = false;
		}
		if (num <= 0)
		{
			num = 24;
		}
		if (isAm)
		{
			clock.text = num + " AM";
			if (num == 24)
			{
				clock.text = "12 AM";
			}
		}
		else
		{
			clock.text = num - 12 + " PM";
			if (num == 12)
			{
				clock.text = "12 PM";
			}
		}
	}
}
