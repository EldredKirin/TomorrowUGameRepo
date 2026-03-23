using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LampPostSwitch : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer spriteRenderer;

	[SerializeField]
	private PlayerStats playerStats;

	[SerializeField]
	private Sprite spriteToSwitchToNight;

	[SerializeField]
	private Sprite spriteToSwitchToDay;

	[SerializeField]
	private Light2D light;

	public Color day = new Color(0f, 0f, 0f);

	public Color night = new Color(1f, 1f, 1f);

	private void Start()
	{
	}

	private void Update()
	{
		int timeOfDay = playerStats.getTimeOfDay();
		if (timeOfDay >= 18)
		{
			spriteRenderer.sprite = spriteToSwitchToNight;
			light.color = night;
		}
		else if (timeOfDay < 18)
		{
			spriteRenderer.sprite = spriteToSwitchToDay;
			light.color = day;
		}
	}
}
