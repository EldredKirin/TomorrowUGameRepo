using UnityEngine;

public class StaticScript : MonoBehaviour
{
	public static string destinationLevel;

	public static float Xpos;

	public static float Ypos;

	public void setDestination(float destinationX, float destinationY)
	{
		Xpos = destinationX;
		Ypos = destinationY;
	}

	public float getXpos()
	{
		return Xpos;
	}

	public float getYpos()
	{
		return Ypos;
	}

	public void setNewScene(string newLevel)
	{
		destinationLevel = newLevel;
	}

	public string getNewScene()
	{
		return destinationLevel;
	}
}
