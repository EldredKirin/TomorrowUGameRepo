using UnityEngine;

public class ObjectZShift : MonoBehaviour
{
	private new Transform transform;

	private BoxCollider2D boxCollider2D;

	private PolygonCollider2D polygonCollider2D;

	public float levelMaxHeight = 27f;

	public float levelMinHeight = -23f;

	private float YPos;

	private float ZPos;

	private float range;

	private void Start()
	{
		if (GetComponent<BoxCollider2D>() != null)
		{
			range = Mathf.Abs(levelMaxHeight) + Mathf.Abs(levelMaxHeight);
			transform = GetComponent<Transform>();
			boxCollider2D = GetComponent<BoxCollider2D>();
			YPos = transform.position.y + Mathf.Abs(levelMinHeight) + boxCollider2D.offset.y;
			ZPos = YPos / range;
			transform.position = new Vector3(transform.position.x, transform.position.y, ZPos);
		}
		else if (GetComponent<PolygonCollider2D>() != null)
		{
			range = Mathf.Abs(levelMaxHeight) + Mathf.Abs(levelMaxHeight);
			transform = GetComponent<Transform>();
			polygonCollider2D = GetComponent<PolygonCollider2D>();
			YPos = transform.position.y + Mathf.Abs(levelMinHeight) + polygonCollider2D.offset.y;
			ZPos = YPos / range;
			transform.position = new Vector3(transform.position.x, transform.position.y, ZPos);
		}
	}

	private void Update()
	{
	}
}
