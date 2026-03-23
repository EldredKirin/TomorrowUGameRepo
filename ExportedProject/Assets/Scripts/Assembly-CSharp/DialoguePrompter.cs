using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialoguePrompter : MonoBehaviour
{
	private bool hasBeenPrompted;

	[SerializeField]
	public string prompt;

	[SerializeField]
	public int type;

	[SerializeField]
	public string speaker;

	[SerializeField]
	public string special;

	[SerializeField]
	private StaticScript staticScript;

	public GameObject dialoguePrompterHUD;

	public TMP_Text text;

	public TMP_Text speakerText;

	public Button confirmButton;

	public Button denyButton;

	public GameObject textBox;

	public GameObject nameBox;

	public Scene scene;

	public GameObject alarmClock;

	public Text alarmText;

	public PlayerStats playerStats;

	private void Start()
	{
		dialoguePrompterHUD.SetActive(value: false);
		Debug.Log("prompter Loaded");
		confirmButton.onClick.AddListener(confirm);
		denyButton.onClick.AddListener(decline);
		scene = SceneManager.GetActiveScene();
	}

	public void Update()
	{
		if (type != 4)
		{
			return;
		}
		int wakeUpTime = playerStats.wakeUpTime;
		if ((playerStats.wakeUpTime < 12) ? true : false)
		{
			alarmText.text = wakeUpTime + "AM";
			if (wakeUpTime == 0)
			{
				alarmText.text = "12PM";
			}
		}
		else
		{
			alarmText.text = wakeUpTime - 12 + "PM";
			if (wakeUpTime == 12)
			{
				alarmText.text = "12AM";
			}
		}
		playerStats.setWakeUpTime(wakeUpTime);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (type != 0)
		{
			openPrompt(type, special);
		}
		Debug.Log(type.ToString());
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		hasBeenPrompted = false;
	}

	private void confirm()
	{
		dialoguePrompterHUD.SetActive(value: false);
		Debug.Log("Button Success!");
		Time.timeScale = 1f;
		if (type == 0 && hasBeenPrompted)
		{
			dialoguePrompterHUD.SetActive(value: false);
			staticScript.setNewScene(scene.name);
			staticScript.setDestination(playerStats.transform.position.x, playerStats.transform.position.y);
			SceneManager.LoadScene(special);
		}
		if (type == 1 && hasBeenPrompted)
		{
			playerStats.modTime(1);
			playerStats.modStress(20);
			playerStats.modHealth(10);
		}
		if (type == 2)
		{
			_ = hasBeenPrompted;
		}
		if (type == 3 && hasBeenPrompted)
		{
			SceneManager.LoadScene("EndDay");
		}
		if (type == 4 && hasBeenPrompted)
		{
			alarmClock.SetActive(value: false);
		}
		if (type == 5 && hasBeenPrompted)
		{
			staticScript.setNewScene(scene.name);
			staticScript.setDestination(playerStats.transform.position.x, playerStats.transform.position.y);
			SceneManager.LoadScene(special);
		}
		hasBeenPrompted = false;
		confirmButton.GetComponentInChildren<Text>().text = "Yes";
	}

	private void decline()
	{
		Time.timeScale = 1f;
		dialoguePrompterHUD.SetActive(value: false);
	}

	public void openPrompt(int typeInt, string specialData)
	{
		hasBeenPrompted = true;
		dialoguePrompterHUD.SetActive(value: true);
		text.enabled = true;
		Debug.Log("Bazinga");
		text.text = prompt;
		confirmButton.enabled = true;
		denyButton.enabled = true;
		textBox.SetActive(value: true);
		nameBox.SetActive(value: false);
		speakerText.enabled = false;
		type = typeInt;
		special = specialData;
		if (type == 2 || type == 5)
		{
			nameBox.SetActive(value: true);
			speakerText.enabled = true;
			speakerText.text = speaker;
		}
		else if (type == 3)
		{
			denyButton.gameObject.SetActive(value: true);
		}
		else if (type == 4)
		{
			alarmClock.SetActive(value: true);
			denyButton.gameObject.SetActive(value: false);
			confirmButton.GetComponentInChildren<Text>().text = "Confirm";
		}
		Time.timeScale = 0f;
	}

	public void increaseWakeUpTime()
	{
		playerStats.wakeUpTime++;
		if (playerStats.wakeUpTime == 24)
		{
			playerStats.wakeUpTime = 0;
		}
	}

	public void decreaseWakeUpTime()
	{
		playerStats.wakeUpTime--;
		if (playerStats.wakeUpTime == -1)
		{
			playerStats.wakeUpTime = 23;
		}
	}
}
