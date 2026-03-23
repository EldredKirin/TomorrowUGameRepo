using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
	[SerializeField]
	private Transform playerTransform;

	private float xStartPos;

	private float yStartPos;

	[SerializeField]
	private StaticScript staticScript;

	public int stem;

	public int ath;

	public int cha;

	public int art;

	public float stress = 90f;

	public float health = 90f;

	public int timeOfDay;

	public int year;

	public int wakeUpTime;

	public Slider stemSlider;

	public Slider athSlider;

	public Slider chaSlider;

	public Slider artSlider;

	public Slider healthSlider;

	public Slider stressSlider;

	public Text stemText;

	public Text athText;

	public Text chaText;

	public Text artText;

	public Text healthText;

	public Text stressText;

	public string playerName;

	public int sex;

	public int skinTone;

	public int eyeColor;

	public int favColor;

	public int hairColor;

	public int hairStyle;

	public int accessory;

	public int[] classIDs = new int[5];

	public int[] classGrades = new int[5];

	public int career;

	public int salary;

	public string home;

	public Text careerText;

	public Text salaryText;

	public Text[] classText = new Text[5];

	public Text[] classGradesText = new Text[5];

	public Text homeText;

	public Slider musicVolumeSlider;

	public Slider sfxVolumeSlider;

	private float musicVolume = 1f;

	private float sfxVolume = 1f;

	public bool runStart;

	private void Start()
	{
		loadStats();
		Scene activeScene = SceneManager.GetActiveScene();
		if (activeScene.name.Equals("CreationScreen") || activeScene.name.Equals("TitleScreen") || activeScene.name.Equals("ScheduleScreen") || runStart)
		{
			return;
		}
		stemSlider.value = stem;
		artSlider.value = art;
		chaSlider.value = cha;
		athSlider.value = ath;
		healthSlider.value = health;
		stressSlider.value = stress;
		stemText.text = "Stem\n" + stem;
		athText.text = "Ath\n" + ath;
		chaText.text = "Cha\n" + cha;
		artText.text = "Art\n" + art;
		healthText.text = "Health\n" + health + "/180";
		stressText.text = "Stress\n" + stress + "/180";
		switch (career)
		{
		case -1:
			careerText.text = "Not Employeed";
			break;
		case 0:
			careerText.text = "Diner Worker";
			break;
		case 1:
			careerText.text = "Janitor";
			break;
		case 2:
			careerText.text = "Construction Worker";
			break;
		case 3:
			careerText.text = "Construction Manager";
			break;
		case 4:
			careerText.text = "Receptionist";
			break;
		case 5:
			careerText.text = "Photographer";
			break;
		case 6:
			careerText.text = "Beautician";
			break;
		case 7:
			careerText.text = "Paralegal";
			break;
		case 8:
			careerText.text = "Medical Assistant";
			break;
		case 9:
			careerText.text = "IT Technician";
			break;
		case 10:
			careerText.text = "Sports Coach";
			break;
		case 11:
			careerText.text = "Professional Athelete";
			break;
		case 12:
			careerText.text = "Professional Artist";
			break;
		case 13:
			careerText.text = "Nurse";
			break;
		case 14:
			careerText.text = "Teacher";
			break;
		case 15:
			careerText.text = "Lawyer";
			break;
		case 16:
			careerText.text = "Doctor";
			break;
		case 17:
			careerText.text = "Professor";
			break;
		}
		for (int i = 0; i < classIDs.Length; i++)
		{
			switch (classIDs[i])
			{
			case 0:
				classText[i].text = "Math";
				break;
			case 1:
				classText[i].text = "Science";
				break;
			case 2:
				classText[i].text = "English";
				break;
			case 3:
				classText[i].text = "Gym";
				break;
			case 4:
				classText[i].text = "Art";
				break;
			case 5:
				classText[i].text = "Speech";
				break;
			case 6:
				classText[i].text = "Shop";
				break;
			case 7:
				classText[i].text = "Technology";
				break;
			}
		}
		for (int j = 0; j < classIDs.Length; j++)
		{
			classGradesText[j].text = classGrades[j].ToString() ?? "";
		}
	}

	public void Update()
	{
		if (musicVolumeSlider != null)
		{
			musicVolume = musicVolumeSlider.value;
		}
		if (sfxVolumeSlider != null)
		{
			sfxVolume = sfxVolumeSlider.value;
		}
	}

	public void setStartPos(float posX, float posY)
	{
		xStartPos = posX;
		yStartPos = posY;
	}

	public float getXPos()
	{
		return xStartPos;
	}

	public float getYPos()
	{
		return yStartPos;
	}

	public int getStem()
	{
		return stem;
	}

	public void modStem(int mod)
	{
		stem += mod;
		stemSlider.value = stem;
		stemText.text = "Stem\n" + stem;
		writeStats();
	}

	public int getAth()
	{
		return ath;
	}

	public void modAth(int mod)
	{
		ath += mod;
		athSlider.value = ath;
		athText.text = "Ath\n" + ath;
		writeStats();
	}

	internal void takeStats(int stem, int art, int ath, int cha)
	{
		throw new NotImplementedException();
	}

	public int getCha()
	{
		return cha;
	}

	public void modCha(int mod)
	{
		cha += mod;
		chaSlider.value = cha;
		chaText.text = "Cha\n" + cha;
		writeStats();
	}

	public int getArt()
	{
		return art;
	}

	public void modArt(int mod)
	{
		art += mod;
		artSlider.value = art;
		artText.text = "Art\n" + art;
		writeStats();
	}

	public float getHealth()
	{
		return health;
	}

	public void modHealth(int mod)
	{
		health += mod;
		healthSlider.value = health;
		healthText.text = "Health\n" + health + "/180";
		writeStats();
	}

	public float getStress()
	{
		return stress;
	}

	public void modStress(int mod)
	{
		stress += mod;
		stressSlider.value = stress;
		stressText.text = "Stress\n" + stress + "/180";
		writeStats();
	}

	public int getTimeOfDay()
	{
		return timeOfDay;
	}

	public void modTime(int mod)
	{
		timeOfDay += mod;
		writeStats();
	}

	public int getYear()
	{
		return year;
	}

	public void nextYear()
	{
		year++;
		timeOfDay = wakeUpTime;
		writeStats();
	}

	public string getAddress()
	{
		return home;
	}

	public void setWakeUpTime(int wakeUpTime)
	{
		this.wakeUpTime = wakeUpTime;
		writeStats();
	}

	public int getWakeUpTime()
	{
		return wakeUpTime;
	}

	public float getMusicVolume()
	{
		return musicVolume;
	}

	public float getSfxVolume()
	{
		return sfxVolume;
	}

	public void writeStats()
	{
		SaveSystem.SavePlayer(this);
	}

	public void loadStats()
	{
		PlayerData playerData = SaveSystem.LoadPlayer();
		stem = playerData.stem;
		ath = playerData.ath;
		art = playerData.arts;
		cha = playerData.cha;
		timeOfDay = playerData.time;
		stress = playerData.stress;
		health = playerData.health;
		year = playerData.year;
		playerName = playerData.playerName;
		sex = playerData.sex;
		skinTone = playerData.skinTone;
		eyeColor = playerData.eyeColor;
		favColor = playerData.favColor;
		hairColor = playerData.hairColor;
		hairStyle = playerData.hairStyle;
		accessory = playerData.accessory;
		classIDs = playerData.classIDs;
		classGrades = playerData.classGrades;
		career = playerData.career;
		salary = playerData.salary;
		wakeUpTime = playerData.wakeUpTime;
		home = playerData.home;
		if (musicVolumeSlider != null)
		{
			musicVolumeSlider.value = playerData.musicVolume;
		}
		musicVolume = playerData.musicVolume;
		if (sfxVolumeSlider != null)
		{
			sfxVolumeSlider.value = playerData.sfxVolume;
		}
		sfxVolume = playerData.sfxVolume;
		Scene activeScene = SceneManager.GetActiveScene();
		if (!activeScene.name.Equals("CreationScreen") && !activeScene.name.Equals("TitleScreen"))
		{
			playerTransform.position = new Vector3(staticScript.getXpos(), staticScript.getYpos(), 0f);
		}
	}

	public void takeStats(int stem, int ath, int art, int cha, int timeOfDay, float stress, float health, int year, string playerName, int sex, int skinTone, int eyeColor, int favColor, int hairColor, int hairStyle, int accessory, int[] classIDs, int[] classGrades, int career, int salary, int wakeUpTime, string home, float xPos, float yPos)
	{
		this.stem = stem;
		this.ath = ath;
		this.art = art;
		this.cha = cha;
		this.timeOfDay = timeOfDay;
		this.health = health;
		this.stress = stress;
		this.year = year;
		this.playerName = playerName;
		this.sex = sex;
		this.skinTone = skinTone;
		this.eyeColor = eyeColor;
		this.favColor = favColor;
		this.hairColor = hairColor;
		this.hairStyle = hairStyle;
		this.accessory = accessory;
		this.classIDs = classIDs;
		this.classGrades = classGrades;
		this.career = career;
		this.salary = salary;
		this.wakeUpTime = wakeUpTime;
		this.home = home;
		xStartPos = xPos;
		yStartPos = yPos;
		writeStats();
	}

	public void takeSchedule(int[] classIDs)
	{
		this.classIDs = classIDs;
		writeStats();
	}
}
