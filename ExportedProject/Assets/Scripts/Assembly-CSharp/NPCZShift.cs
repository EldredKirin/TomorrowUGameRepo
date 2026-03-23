using UnityEngine;

public class NPCZShift : MonoBehaviour
{
	private new Transform transform;

	private BoxCollider2D boxCollider2D;

	public float levelMaxHeight = 27f;

	public float levelMinHeight = -23f;

	private float YPos;

	private float ZPos;

	private float range;

	private void Start()
	{
	}

	private void Update()
	{
		range = Mathf.Abs(levelMaxHeight) + Mathf.Abs(levelMaxHeight);
		transform = GetComponent<Transform>();
		boxCollider2D = GetComponent<BoxCollider2D>();
		YPos = transform.position.y + Mathf.Abs(levelMinHeight) + boxCollider2D.offset.y;
		ZPos = YPos / range;
		transform.position = new Vector3(transform.position.x, transform.position.y, ZPos);
	}
}
