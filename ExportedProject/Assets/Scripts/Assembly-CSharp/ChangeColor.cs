using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class ChangeColor : MonoBehaviour
{
	public Color good = new Color(0f, 1f, 0f, 1f);

	public Color mid = new Color(1f, 1f, 0f, 1f);

	public Color bad = new Color(1f, 0f, 0f, 1f);

	[SerializeField]
	private Light2D light2D;

	[SerializeField]
	private SpeechAudienceMember speechAudienceMember;

	private float att;

	private void Start()
	{
	}

	private void Update()
	{
		att = speechAudienceMember.att;
		if (speechAudienceMember.att >= 5f)
		{
			light2D.color = good;
		}
		else if (speechAudienceMember.att >= 2.5f && speechAudienceMember.att <= 4.9f)
		{
			light2D.color = mid;
		}
		else if (speechAudienceMember.att <= 2.4f && speechAudienceMember.att >= 0f)
		{
			light2D.color = bad;
		}
	}
}
