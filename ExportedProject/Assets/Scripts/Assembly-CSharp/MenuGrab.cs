using UnityEngine;
using UnityEngine.UI;

public class MenuGrab : MonoBehaviour
{
	public static bool isMenuUp;

	public int slide;

	public Text title;

	public GameObject menuUI;

	public GameObject homeScreen;

	public GameObject screen0UI;

	public GameObject screen1UI;

	public GameObject screen2UI;

	public GameObject screen3UI;

	public GameObject screen4UI;

	public Button button0;

	public Button button1;

	public Button button2;

	public Button button3;

	public Button button4;

	public GameObject closeButton;

	public Button close;

	public Animator animator;

	private void Start()
	{
		button0.onClick.AddListener(delegate
		{
			RenderMenu(0);
		});
		button1.onClick.AddListener(delegate
		{
			RenderMenu(1);
		});
		button2.onClick.AddListener(delegate
		{
			RenderMenu(2);
		});
		button3.onClick.AddListener(delegate
		{
			RenderMenu(3);
		});
		button4.onClick.AddListener(delegate
		{
			RenderMenu(4);
		});
		close.onClick.AddListener(delegate
		{
			RenderMenu(-1);
		});
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (isMenuUp)
			{
				CloseMenu();
			}
			else
			{
				OpenMenu();
			}
		}
	}

	public void MenuButtonClick()
	{
		if (isMenuUp)
		{
			CloseMenu();
		}
		else
		{
			OpenMenu();
		}
	}

	private void CloseMenu()
	{
		animator.SetBool("IsOpen", value: false);
		Time.timeScale = 1f;
		isMenuUp = false;
	}

	private void OpenMenu()
	{
		menuUI.SetActive(value: true);
		Time.timeScale = 0f;
		isMenuUp = true;
		animator.SetBool("IsOpen", value: true);
	}

	public void RenderMenu(int slide)
	{
		switch (slide)
		{
		case -1:
			Debug.Log("Home Screen Displayed");
			closeButton.SetActive(value: false);
			screen0UI.SetActive(value: false);
			screen1UI.SetActive(value: false);
			screen2UI.SetActive(value: false);
			screen3UI.SetActive(value: false);
			screen4UI.SetActive(value: false);
			homeScreen.SetActive(value: true);
			title.text = "Home";
			break;
		case 0:
			Debug.Log("Stats Screen Displayed");
			closeButton.SetActive(value: true);
			screen0UI.SetActive(value: true);
			screen1UI.SetActive(value: false);
			screen2UI.SetActive(value: false);
			screen3UI.SetActive(value: false);
			screen4UI.SetActive(value: false);
			homeScreen.SetActive(value: false);
			title.text = "Stats";
			Debug.Log("Stats Screen Displayed");
			break;
		case 1:
			closeButton.SetActive(value: true);
			screen0UI.SetActive(value: false);
			screen1UI.SetActive(value: true);
			screen2UI.SetActive(value: false);
			screen3UI.SetActive(value: false);
			screen4UI.SetActive(value: false);
			homeScreen.SetActive(value: false);
			title.text = "Finances";
			break;
		case 2:
			closeButton.SetActive(value: true);
			screen0UI.SetActive(value: false);
			screen1UI.SetActive(value: false);
			screen2UI.SetActive(value: true);
			screen3UI.SetActive(value: false);
			screen4UI.SetActive(value: false);
			homeScreen.SetActive(value: false);
			title.text = "Player Info";
			break;
		case 3:
			closeButton.SetActive(value: true);
			screen0UI.SetActive(value: false);
			screen1UI.SetActive(value: false);
			screen2UI.SetActive(value: false);
			screen3UI.SetActive(value: true);
			screen4UI.SetActive(value: false);
			homeScreen.SetActive(value: false);
			title.text = "Grades";
			break;
		case 4:
			closeButton.SetActive(value: true);
			screen0UI.SetActive(value: false);
			screen1UI.SetActive(value: false);
			screen2UI.SetActive(value: false);
			screen3UI.SetActive(value: false);
			screen4UI.SetActive(value: true);
			homeScreen.SetActive(value: false);
			title.text = "Grades";
			break;
		}
	}
}
