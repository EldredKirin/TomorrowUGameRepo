using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
	[SerializeField]
	private PlayerStats playerStats;

	public void NewGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void ContinueGame()
	{
		SceneManager.LoadScene(playerStats.getAddress());
	}
}
