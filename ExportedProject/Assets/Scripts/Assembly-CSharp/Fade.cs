using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
	[SerializeField]
	private GameObject fade;

	private RawImage rawImage;

	public Color color;

	public float fadeTime;

	public bool hasLeftScene;

	private void Start()
	{
		rawImage = fade.GetComponent<RawImage>();
		color = rawImage.color;
	}

	private void Update()
	{
		if (!hasLeftScene && color.a >= 0f)
		{
			color.a -= fadeTime * Time.unscaledDeltaTime;
			rawImage.color = color;
		}
		if (hasLeftScene)
		{
			color.a += fadeTime * Time.unscaledDeltaTime;
			rawImage.color = color;
		}
		if (rawImage.color.a <= 0f)
		{
			fade.SetActive(value: false);
		}
	}
}
