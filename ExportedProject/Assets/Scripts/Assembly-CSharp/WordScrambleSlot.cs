using UnityEngine;

public class WordScrambleSlot : MonoBehaviour
{
	public string letter;

	public int index;

	public WordScrambleLetter wordScrambleLetter;

	private void Start()
	{
	}

	private void Update()
	{
		if (wordScrambleLetter != null)
		{
			letter = wordScrambleLetter.letter;
		}
	}
}
