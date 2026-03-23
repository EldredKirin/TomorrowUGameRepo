using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class DayNightBehaviour : MonoBehaviour
{
	public PlayerStats playerStats;

	public Color morningColor = new Color(1f, 0.92f, 0.5f);

	public Color dayColor = new Color(1f, 1f, 1f);

	public Color eveningColor = new Color(0.9f, 0.7f, 0.75f);

	public Color nightColor = new Color(0.25f, 0.5f, 0.7f);

	public bool isInterior;

	private Light2D light2D;

	public bool daytime { get; private set; }

	private void Start()
	{
		light2D = GetComponent<Light2D>();
	}

	private void Update()
	{
		int timeOfDay = playerStats.getTimeOfDay();
		if (!isInterior)
		{
			if (timeOfDay <= 8 && timeOfDay >= 7)
			{
				light2D.color = morningColor;
			}
			else if (timeOfDay <= 15 && timeOfDay >= 9)
			{
				light2D.color = dayColor;
			}
			else if (timeOfDay >= 16 && timeOfDay <= 17)
			{
				light2D.color = eveningColor;
			}
			else if (timeOfDay >= 18)
			{
				light2D.color = nightColor;
			}
		}
	}
}
