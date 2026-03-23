using UnityEngine;

public class cameraFollow : MonoBehaviour
{
	public Transform cam;

	public Transform board;

	private void Update()
	{
		cam.position = new Vector3(board.position.x, board.position.y, -10f);
	}
}
