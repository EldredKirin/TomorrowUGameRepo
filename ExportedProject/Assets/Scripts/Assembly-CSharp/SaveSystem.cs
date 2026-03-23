using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSystem
{
	public static void SavePlayer(PlayerStats player)
	{
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		FileStream fileStream = new FileStream(Application.persistentDataPath + "/player.sav", FileMode.Create);
		PlayerData graph = new PlayerData(player);
		binaryFormatter.Serialize(fileStream, graph);
		fileStream.Close();
	}

	public static PlayerData LoadPlayer()
	{
		string text = Application.persistentDataPath + "/player.sav";
		if (File.Exists(text))
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			FileStream fileStream = new FileStream(text, FileMode.Open);
			PlayerData result = binaryFormatter.Deserialize(fileStream) as PlayerData;
			fileStream.Close();
			return result;
		}
		Debug.LogError("Save file not found in " + text);
		return null;
	}
}
