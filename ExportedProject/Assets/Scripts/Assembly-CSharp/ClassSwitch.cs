using System.Collections;
using UnityEngine;

public class ClassSwitch : MonoBehaviour
{
	[SerializeField]
	private string newLevel;

	[SerializeField]
	public PlayerStats playerStats;

	private int classSlot;

	[SerializeField]
	public int room;

	public DialoguePrompter dialoguePrompter;

	private bool isReady;

	private void Update()
	{
		classSlot = playerStats.getTimeOfDay() - 8;
		if (classSlot == 3)
		{
			classSlot = -1;
		}
		else if (classSlot == 4)
		{
			classSlot = -2;
		}
		else if (classSlot == 5)
		{
			classSlot = 3;
		}
		else if (classSlot == 6)
		{
			classSlot = 4;
		}
		if (!isReady)
		{
			StartCoroutine(sleep());
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player") && isReady && playerStats.classIDs[classSlot] == room && playerStats.classIDs[0] != playerStats.classIDs[1])
		{
			dialoguePrompter.openPrompt(0, newLevel);
		}
	}

	private IEnumerator sleep()
	{
		yield return new WaitForSeconds(1f);
		isReady = true;
	}
}
