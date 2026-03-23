using UnityEngine;
using UnityEngine.SceneManagement;

public class BGSoundScript : MonoBehaviour
{
	[SerializeField]
	private AudioClip[] songs;

	[SerializeField]
	private AudioSource audioSource;

	public AudioClip currentTrack;

	public int currentTrackIndex;

	private AudioClip nextTrack;

	private GameObject areaTrack;

	private GameObject playerObject;

	private static BGSoundScript instance;

	public static BGSoundScript Instance => instance;

	private void Awake()
	{
		if (instance != null && instance != this)
		{
			Object.Destroy(base.gameObject);
		}
		else
		{
			instance = this;
		}
		Object.DontDestroyOnLoad(base.gameObject);
	}

	private void OnEnable()
	{
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		areaTrack = GameObject.Find("AreaTrack");
		playerObject = GameObject.Find("Player");
	}

	private void Update()
	{
		audioSource.volume = playerObject.GetComponent<PlayerStats>().getMusicVolume();
		if (areaTrack.GetComponent<selectmusic>().areaTrack != currentTrackIndex && areaTrack.GetComponent<selectmusic>().areaNightTrack != currentTrackIndex)
		{
			if (playerObject.GetComponent<PlayerStats>().getTimeOfDay() >= 18 || playerObject.GetComponent<PlayerStats>().getTimeOfDay() < 5)
			{
				currentTrack = songs[areaTrack.GetComponent<selectmusic>().areaNightTrack];
				audioSource.clip = currentTrack;
				audioSource.Play();
				currentTrackIndex = areaTrack.GetComponent<selectmusic>().areaNightTrack;
			}
			else
			{
				currentTrack = songs[areaTrack.GetComponent<selectmusic>().areaTrack];
				audioSource.clip = currentTrack;
				audioSource.Play();
				currentTrackIndex = areaTrack.GetComponent<selectmusic>().areaTrack;
			}
		}
	}
}
