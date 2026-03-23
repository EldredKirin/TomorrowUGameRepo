using UnityEngine;
using UnityEngine.SceneManagement;

public class StudyBookshelfPrompt : MonoBehaviour
{
	[SerializeField]
	private StaticScript staticScript;

	public Scene scene;

	public string special;

	[SerializeField]
	private PlayerStats playerStats;

	private void Start()
	{
		scene = SceneManager.GetActiveScene();
	}

	private void Update()
	{
	}

	public void onClick()
	{
		Time.timeScale = 1f;
		staticScript.setNewScene(scene.name);
		staticScript.setDestination(playerStats.transform.position.x, playerStats.transform.position.y);
		SceneManager.LoadScene(special);
	}
}
