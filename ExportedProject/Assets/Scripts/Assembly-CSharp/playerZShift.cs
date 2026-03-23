using UnityEngine;

public class playerZShift : MonoBehaviour
{
	[SerializeField]
	private new Transform transform;

	[SerializeField]
	private BoxCollider2D boxCollider2D;

	public float levelMaxHeight = 27f;

	public float levelMinHeight = -23f;

	private float range;

	private float playerYPos;

	private float playerZPos;

	private void Start()
	{
		range = Mathf.Abs(levelMaxHeight) + Mathf.Abs(levelMaxHeight);
	}

	private void Update()
	{
		playerYPos = transform.position.y + Mathf.Abs(levelMinHeight) + boxCollider2D.offset.y;
		playerZPos = playerYPos / range;
		transform.position = new Vector3(transform.position.x, transform.position.y, playerZPos);
	}
}
