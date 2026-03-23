using UnityEngine;
using UnityEngine.UI;

public class WordScrambleLetter : MonoBehaviour
{
	public string letter;

	public bool inPlace;

	public int index;

	private BoxCollider2D collider;

	private Vector3 originalPosition;

	[SerializeField]
	private WordScrambleScript wordScrambleScript;

	public Text letterText;

	public Transform letterTextTransform;

	public GameObject targetObj;

	public RectTransform canvasRect;

	private void Start()
	{
		collider = GetComponent<BoxCollider2D>();
		inPlace = false;
		originalPosition = GetComponent<Transform>().position;
	}

	private void Update()
	{
		Vector2 point = wordScrambleScript.sendMousePoint();
		if (Input.GetMouseButtonDown(0) && wordScrambleScript.gameHasStarted && collider == Physics2D.OverlapPoint(point) && !inPlace)
		{
			Debug.Log("Clicked" + index);
			GetComponent<Transform>().position = new Vector3(wordScrambleScript.wordScrambleSlot[wordScrambleScript.letterCount].GetComponent<Transform>().position.x, wordScrambleScript.wordScrambleSlot[wordScrambleScript.letterCount].GetComponent<Transform>().position.y, 0f);
			wordScrambleScript.wordScrambleSlot[wordScrambleScript.letterCount].wordScrambleLetter = this;
			wordScrambleScript.letterCount++;
			inPlace = true;
		}
		Vector3 position = new Vector3(targetObj.transform.position.x, targetObj.transform.position.y, targetObj.transform.position.z);
		Vector2 screenPoint = Camera.main.WorldToScreenPoint(position);
		RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRect, screenPoint, null, out var localPoint);
		letterTextTransform.localPosition = localPoint;
		letterText.text = letter;
	}

	public void setLetter(string l)
	{
		letter = l;
	}

	public void detatch()
	{
		inPlace = false;
		GetComponent<Transform>().position = originalPosition;
	}
}
