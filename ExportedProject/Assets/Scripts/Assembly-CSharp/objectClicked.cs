using UnityEngine;

public class objectClicked : MonoBehaviour
{
	[SerializeField]
	private GameObject beaker;

	[SerializeField]
	private Collider2D beakerCollider;

	[SerializeField]
	private chemistryChaos chemChaos;

	private void Start()
	{
	}

	private void Update()
	{
		Vector2 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		if (Input.GetMouseButtonDown(0) && beakerCollider == Physics2D.OverlapPoint(point))
		{
			chemChaos.CurrentClickedGameObject(beaker);
			Debug.Log("CLicked");
		}
	}
}
