using System;

[Serializable]
public class PlayerData
{
	public int ath;

	public int stem;

	public int arts;

	public int cha;

	public float stress;

	public float health;

	public int year;

	public int time;

	public string playerName;

	public int sex;

	public int skinTone;

	public int eyeColor;

	public int favColor;

	public int hairColor;

	public int hairStyle;

	public int accessory;

	public int[] classIDs;

	public int[] classGrades;

	public int career;

	public int salary;

	public int wakeUpTime;

	public string home;

	public float xPos;

	public float yPos;

	public float musicVolume = 1f;

	public float sfxVolume = 1f;

	public PlayerData(PlayerStats player)
	{
		ath = player.getAth();
		stem = player.getStem();
		arts = player.getArt();
		cha = player.getCha();
		stress = player.getStress();
		health = player.getHealth();
		year = player.getYear();
		time = player.getTimeOfDay();
		playerName = player.playerName;
		sex = player.sex;
		skinTone = player.skinTone;
		eyeColor = player.eyeColor;
		favColor = player.favColor;
		hairColor = player.hairColor;
		hairStyle = player.hairStyle;
		accessory = player.accessory;
		classIDs = player.classIDs;
		classGrades = player.classGrades;
		career = player.career;
		salary = player.salary;
		wakeUpTime = player.wakeUpTime;
		home = player.getAddress();
		xPos = player.getXPos();
		yPos = player.getYPos();
		musicVolume = player.getMusicVolume();
		sfxVolume = player.getSfxVolume();
	}
}
