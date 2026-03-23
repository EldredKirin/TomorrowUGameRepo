using UnityEngine;

public class disableColliderOnSchoolTime : MonoBehaviour
{
	[SerializeField]
	private PlayerStats playerStats;

	[SerializeField]
	private BoxCollider2D collider;

	private void Start()
	{
	}

	private void Update()
	{
		if (playerStats.getTimeOfDay() >= 9 && playerStats.getTimeOfDay() < 15)
		{
			collider.enabled = false;
		}
		else
		{
			collider.enabled = true;
		}
	}
}
