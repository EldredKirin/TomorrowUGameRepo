using UnityEngine;

public class StressNeedle : MonoBehaviour
{
	[SerializeField]
	private Transform needleTransform;

	private float maxAngle = -90f;

	private float minAngle = 90f;

	[SerializeField]
	private PlayerStats playerStats;

	public float currentValue = 90f;

	private void Update()
	{
		currentValue = playerStats.getStress();
		needleTransform.eulerAngles = new Vector3(0f, 0f, GetSpeedRotation());
	}

	private float GetSpeedRotation()
	{
		float num = minAngle - maxAngle;
		float num2 = currentValue / 180f;
		return minAngle - num2 * num;
	}
}
