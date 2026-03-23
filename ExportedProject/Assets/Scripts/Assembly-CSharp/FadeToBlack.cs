using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeToBlack : MonoBehaviour
{
	[SerializeField]
	private PlayerStats playerStats;

	[SerializeField]
	private float destinationX;

	[SerializeField]
	private float destinationY;

	[SerializeField]
	private string newLevel;

	[SerializeField]
	private StaticScript staticScript;

	[SerializeField]
	private Fade fade;

	[SerializeField]
	private GameObject fadeObject;

	public Transform TeleportToL2Dest;

	public bool HasBeenEntered;

	public float timeToWait;

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
			StartCoroutine(onTriggerWait());
		}
	}

	private IEnumerator onTriggerWait()
	{
		fadeObject.SetActive(value: true);
		staticScript.setDestination(destinationX, destinationY);
		fade.hasLeftScene = true;
		HasBeenEntered = true;
		yield return new WaitForSeconds(timeToWait);
		SceneManager.LoadScene(newLevel);
		playerStats.writeStats();
		Debug.Log("Scene Fading");
	}
}
