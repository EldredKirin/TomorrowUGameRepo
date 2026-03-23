using UnityEngine;
using UnityEngine.UI;

public class SpeechScript : MonoBehaviour
{
	public Transform view;

	public float mouseXPos;

	public float horizontalSize;

	public float scalar;

	public SpeechAudienceMember[] audience = new SpeechAudienceMember[10];

	public float audienceDecay = 1f;

	public float speechSpeed = 5f;

	public float contentRemaining;

	public Slider contentRemainingSlider;

	public bool hasUnClicked;

	public Text timing;

	[SerializeField]
	private Slider timer;

	[SerializeField]
	private ClipboardUI clipboardUI;

	public bool hasStarted;

	private void Start()
	{
		horizontalSize = Screen.width;
		scalar = 180f / horizontalSize;
	}

	private void Update()
	{
		if (hasStarted)
		{
			mouseXPos = Input.mousePosition.x;
			if (mouseXPos > horizontalSize)
			{
				mouseXPos = horizontalSize;
			}
			if (mouseXPos < 0f)
			{
				mouseXPos = 0f;
			}
			view.rotation = Quaternion.Euler(0f, 0f, -1f * (mouseXPos * scalar) - 90f);
			contentRemaining += 1f / speechSpeed * Time.deltaTime;
			contentRemainingSlider.value = contentRemaining;
			if (Input.GetMouseButtonDown(0) && hasUnClicked)
			{
				timingClick(contentRemaining);
				contentRemaining = 0f;
			}
			else
			{
				hasUnClicked = true;
			}
			if (contentRemaining > 1f)
			{
				timing.text = "Missed!";
				contentRemaining = 0f;
			}
			timer.value -= 1f * Time.deltaTime;
			if (timer.value <= 0f)
			{
				hasStarted = false;
				gameEnd();
			}
		}
	}

	private void timingClick(float contentRemaining)
	{
		hasUnClicked = false;
		if ((double)contentRemaining > 0.8 && (double)contentRemaining <= 0.9)
		{
			timing.text = "Good!";
			for (int i = 0; i < audience.Length; i++)
			{
				audience[i].att += 1f;
			}
		}
		if ((double)contentRemaining > 0.9 && (double)contentRemaining <= 0.95)
		{
			timing.text = "Great!";
			for (int j = 0; j < audience.Length; j++)
			{
				audience[j].att += 1.5f;
			}
		}
		if ((double)contentRemaining > 0.95)
		{
			timing.text = "Perfect!";
			for (int k = 0; k < audience.Length; k++)
			{
				audience[k].att += 2f;
			}
		}
	}

	public void startGame()
	{
		hasStarted = true;
		clipboardUI.gameStart();
	}

	private void gameEnd()
	{
		clipboardUI.gameOver();
		int num = 0;
		for (int i = 0; i < audience.Length; i++)
		{
			int num2 = (int)audience[i].attentionSlider.value + 3;
			if (num2 > 10)
			{
				num2 = 10;
			}
			num += num2;
		}
		clipboardUI.addScore(num, new int[6] { 0, 0, 3, 5, 0, -10 });
	}
}
