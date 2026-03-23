using UnityEngine;
using UnityEngine.UI;

public class SpeechAudienceMember : MonoBehaviour
{
	public float att;

	public Slider attentionSlider;

	public Transform attentionSliderTransform;

	public GameObject targetObj;

	public SpeechScript speechScript;

	private bool isOverlapped;

	public RectTransform canvasRect;

	private void Start()
	{
		att = 5f;
		float y = targetObj.transform.position.y + 0.7f;
		Vector3 position = new Vector3(targetObj.transform.position.x, y, 0f);
		Vector2 screenPoint = Camera.main.WorldToScreenPoint(position);
		RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRect, screenPoint, null, out var localPoint);
		attentionSliderTransform.localPosition = localPoint;
	}

	private void Update()
	{
		if (speechScript.hasStarted)
		{
			att -= speechScript.audienceDecay * Time.deltaTime;
			if (att < 0f)
			{
				att = 0f;
			}
			if (att > 10f)
			{
				att = 10f;
			}
			attentionSlider.value = att;
			if (isOverlapped)
			{
				att += 2f * Time.deltaTime;
			}
		}
	}

	public float getAtt()
	{
		return attentionSlider.value;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		isOverlapped = true;
		Debug.Log("entered");
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		isOverlapped = false;
		Debug.Log("exited");
	}
}
