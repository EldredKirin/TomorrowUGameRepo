using UnityEngine;

public class CameraClamp : MonoBehaviour
{
	public float maxX;

	public float minX;

	public float maxY;

	public float minY;

	[SerializeField]
	private Transform target;

	private void Update()
	{
		base.transform.position = new Vector3(Mathf.Clamp(target.position.x, minX, maxX), Mathf.Clamp(target.position.y, minY, maxY), base.transform.position.z);
	}
}
