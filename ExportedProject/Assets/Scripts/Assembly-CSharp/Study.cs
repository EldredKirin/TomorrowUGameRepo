using UnityEngine;
using UnityEngine.UI;

public class Study : MonoBehaviour
{
	[SerializeField]
	private GameObject studyPrompt;

	[SerializeField]
	private Button decline;

	[SerializeField]
	private PlayerStats PlayerStats;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			studyPrompt.SetActive(value: true);
			Time.timeScale = 0f;
		}
	}

	public void closeMenu()
	{
		Time.timeScale = 1f;
		studyPrompt.SetActive(value: false);
	}
}
