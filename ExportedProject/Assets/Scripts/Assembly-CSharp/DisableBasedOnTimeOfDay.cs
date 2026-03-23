using System.Collections.Generic;
using UnityEngine;

public class DisableBasedOnTimeOfDay : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> objects;

	[SerializeField]
	private List<int> startTimes;

	[SerializeField]
	private List<int> durations;

	[SerializeField]
	private PlayerStats playerStats;

	private void Start()
	{
	}

	private void Update()
	{
		for (int i = 0; i < objects.Count; i++)
		{
			if (playerStats.getTimeOfDay() >= startTimes[i] + durations[i] || playerStats.getTimeOfDay() < startTimes[i])
			{
				objects[i].SetActive(value: false);
			}
			else
			{
				objects[i].SetActive(value: true);
			}
		}
	}
}
