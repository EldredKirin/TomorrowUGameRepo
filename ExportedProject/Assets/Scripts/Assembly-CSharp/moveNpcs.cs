using System.Collections;
using UnityEngine;

public class moveNpcs : MonoBehaviour
{
	[SerializeField]
	private Transform npc;

	public float moveSpeed = 1f;

	private float movementX;

	private float movementY;

	private float currentXPos;

	private float currentYPos;

	public float maxXPos = 1f;

	public float minXPos = -1f;

	public float maxYPos = 1f;

	public float minYPos = -1f;

	public int direction;

	private int currDirection;

	private bool isReadyToMove = true;

	public bool isMoving;

	private void Start()
	{
	}

	private void Update()
	{
		if (isReadyToMove)
		{
			StartCoroutine(NpcMovement());
		}
		if (currDirection == 1 && npc.position.y <= maxYPos)
		{
			currentYPos = npc.transform.position.y;
			currentYPos += moveSpeed * Time.deltaTime;
			direction = 1;
			npc.transform.position = new Vector3(npc.transform.position.x, currentYPos, npc.transform.position.z);
		}
		else if (currDirection == 2 && npc.position.x <= maxXPos)
		{
			currentXPos = npc.transform.position.x;
			currentXPos += moveSpeed * Time.deltaTime;
			direction = 2;
			npc.transform.position = new Vector3(currentXPos, npc.transform.position.y, npc.transform.position.z);
		}
		else if (currDirection == 3 && npc.position.y >= minYPos)
		{
			currentYPos = npc.transform.position.y;
			currentYPos -= moveSpeed * Time.deltaTime;
			direction = 3;
			npc.transform.position = new Vector3(npc.transform.position.x, currentYPos, npc.transform.position.z);
		}
		else if (currDirection == 4 && npc.position.x >= minXPos)
		{
			currentXPos = npc.transform.position.x;
			currentXPos -= moveSpeed * Time.deltaTime;
			direction = 4;
			npc.transform.position = new Vector3(currentXPos, npc.transform.position.y, npc.transform.position.z);
		}
	}

	private IEnumerator NpcMovement()
	{
		isMoving = true;
		isReadyToMove = false;
		int num = Random.Range(1, 5);
		int[] moveArray = new int[num];
		for (int i = 0; i < moveArray.Length; i++)
		{
			moveArray[i] = Random.Range(1, 5);
		}
		for (int j = 0; j < moveArray.Length; j++)
		{
			switch (moveArray[j])
			{
			case 1:
				currDirection = 1;
				break;
			case 2:
				currDirection = 2;
				break;
			case 3:
				currDirection = 3;
				break;
			case 4:
				currDirection = 4;
				break;
			}
			yield return new WaitForSeconds(1f);
		}
		currDirection = 0;
		direction = 0;
		isMoving = false;
		yield return new WaitForSeconds(Random.Range(1, 8));
		isReadyToMove = true;
	}
}
