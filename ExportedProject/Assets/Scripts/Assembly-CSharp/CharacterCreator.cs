using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterCreator : MonoBehaviour
{
	public int stem;

	public int ath;

	public int art;

	public int cha;

	public int totalSkillPoints = 20;

	public Button stemButtonUp;

	public Button athButtonUp;

	public Button artButtonUp;

	public Button chaButtonUp;

	public Button stemButtonDown;

	public Button athButtonDown;

	public Button artButtonDown;

	public Button chaButtonDown;

	public Text stemText;

	public Text athText;

	public Text artText;

	public Text chaText;

	public Text totalPointsText;

	public string playerName;

	public int sex;

	public int skinTone;

	public int eyeColor;

	public int favColor;

	public int hairColor;

	public int hairStyle;

	public int accessory;

	public InputField playerNameField;

	public Dropdown sexDropdown;

	public Dropdown skinToneDropdown;

	public Dropdown eyeColorDropdown;

	public Dropdown favColorDropdown;

	public Dropdown hairColorDropdown;

	public Dropdown hairStyleDropdown;

	public Dropdown accessoryDropdown;

	public PlayerStats playerStats;

	[SerializeField]
	private new Transform transform;

	private bool hasInitilized;

	private void Update()
	{
		if (!hasInitilized)
		{
			randomizeButton();
			hasInitilized = true;
		}
		if (stem + ath + art + cha >= 20)
		{
			stemButtonUp.interactable = false;
			athButtonUp.interactable = false;
			artButtonUp.interactable = false;
			chaButtonUp.interactable = false;
		}
		else
		{
			stemButtonUp.interactable = true;
			athButtonUp.interactable = true;
			artButtonUp.interactable = true;
			chaButtonUp.interactable = true;
		}
		if (stem <= 0)
		{
			stemButtonDown.interactable = false;
		}
		else
		{
			stemButtonDown.interactable = true;
		}
		if (ath <= 0)
		{
			athButtonDown.interactable = false;
		}
		else
		{
			athButtonDown.interactable = true;
		}
		if (art <= 0)
		{
			artButtonDown.interactable = false;
		}
		else
		{
			artButtonDown.interactable = true;
		}
		if (cha <= 0)
		{
			chaButtonDown.interactable = false;
		}
		else
		{
			chaButtonDown.interactable = true;
		}
		stemText.text = "STEM: " + stem;
		athText.text = "ATHLETICISM " + ath;
		artText.text = "ARTS " + art;
		chaText.text = "CHARISMA " + cha;
		totalPointsText.text = "SKILL POINTS REMAINING: " + (totalSkillPoints - stem - ath - art - cha);
		playerName = playerNameField.text;
		sex = sexDropdown.value;
		hairStyle = hairStyleDropdown.value;
		accessory = accessoryDropdown.value;
		playerStats.hairStyle = hairStyle;
		playerStats.accessory = accessory;
	}

	public void plusStem()
	{
		stem++;
	}

	public void plusAth()
	{
		ath++;
	}

	public void plusArt()
	{
		art++;
	}

	public void plusCha()
	{
		cha++;
	}

	public void minusStem()
	{
		stem--;
	}

	public void minusAth()
	{
		ath--;
	}

	public void minusArt()
	{
		art--;
	}

	public void minusCha()
	{
		cha--;
	}

	public void setFavoriteColor(int value)
	{
		favColor = value;
		playerStats.favColor = value;
	}

	public void setEyeColor(int value)
	{
		eyeColor = value;
		playerStats.eyeColor = value;
	}

	public void setHairColor(int value)
	{
		hairColor = value;
		playerStats.hairColor = value;
	}

	public void setSkinColor(int value)
	{
		skinTone = value;
		playerStats.skinTone = value;
	}

	public void resetButton()
	{
		stem = 0;
		art = 0;
		ath = 0;
		cha = 0;
		playerNameField.text = "";
		favColor = 0;
		eyeColor = 0;
		hairColor = 0;
		skinTone = 0;
		sexDropdown.value = 0;
		accessoryDropdown.value = 0;
	}

	public void randomizeButton()
	{
		float num = Random.Range(0f, 1f);
		float num2 = Random.Range(0f, 1f);
		float num3 = Random.Range(0f, 1f);
		float num4 = Random.Range(0f, 1f);
		float num5 = num + num2 + num3 + num4;
		num /= num5;
		num2 /= num5;
		num3 /= num5;
		num4 /= num5;
		stem = (int)(num * 20f);
		art = (int)(num2 * 20f);
		ath = (int)(num3 * 20f);
		cha = (int)(num4 * 20f);
		if (ath + art + cha + stem < 20)
		{
			balance();
		}
		favColor = Random.Range(0, 9);
		playerStats.favColor = favColor;
		eyeColor = Random.Range(0, 5);
		playerStats.eyeColor = eyeColor;
		hairColor = Random.Range(0, 5);
		playerStats.hairColor = hairColor;
		hairStyleDropdown.value = Random.Range(0, 4);
		hairStyle = hairColorDropdown.value;
		playerStats.hairStyle = hairStyle;
		skinTone = Random.Range(0, 3);
		playerStats.skinTone = skinTone;
		sexDropdown.value = Random.Range(0, 2);
		sex = sexDropdown.value;
		playerStats.sex = sex;
		accessoryDropdown.value = Random.Range(0, 2);
		accessory = accessoryDropdown.value;
		playerStats.accessory = accessory;
	}

	public void balance()
	{
		int[] array = new int[4] { stem, art, ath, cha };
		int num = 0;
		for (int i = 0; i < 4; i++)
		{
			if (array[i] < array[num])
			{
				num = i;
			}
		}
		switch (num)
		{
		case 0:
			stem++;
			break;
		case 1:
			art++;
			break;
		case 2:
			ath++;
			break;
		case 3:
			cha++;
			break;
		}
		if (ath + art + cha + stem < 20)
		{
			balance();
		}
	}

	public void finalizeStats()
	{
		playerStats.takeStats(stem, ath, art, cha, 7, 90f, 90f, 0, playerName, sex, skinTone, eyeColor, favColor, hairColor, hairStyle, accessory, new int[5], new int[5], -1, 0, 7, "SuburbStart", 2f, -0.5f);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
