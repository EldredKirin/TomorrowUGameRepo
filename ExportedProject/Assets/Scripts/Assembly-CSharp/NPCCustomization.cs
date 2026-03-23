using UnityEngine;

public class NPCCustomization : MonoBehaviour
{
	[SerializeField]
	private characterController controller;

	private moveNpcs moveNPCS;

	[SerializeField]
	private SpriteRenderer bodyRenderer;

	[SerializeField]
	private SpriteRenderer eyeRenderer;

	[SerializeField]
	private SpriteRenderer hairRenderer;

	[SerializeField]
	private SpriteRenderer shirtRenderer;

	[SerializeField]
	private SpriteRenderer pantRenderer;

	[SerializeField]
	private SpriteRenderer armRenderer;

	[SerializeField]
	private SpriteRenderer accesoryRenderer;

	[SerializeField]
	private int eyeColor;

	[SerializeField]
	private int favoriteColor;

	[SerializeField]
	private int hairColor;

	[SerializeField]
	private int hairStyle;

	[SerializeField]
	private int accessory;

	[SerializeField]
	private int skinTone;

	private int direction;

	private float time;

	[SerializeField]
	private float animationTime = 4f;

	private void Start()
	{
		moveNPCS = GetComponent<moveNpcs>();
	}

	private void Update()
	{
		time += animationTime * Time.deltaTime;
		if (time >= 4f)
		{
			time = 0f;
		}
		direction = moveNPCS.direction;
		if (skinTone == 0)
		{
			bodyRenderer.color = controller.Peach;
			armRenderer.color = controller.Peach;
		}
		else if (skinTone == 1)
		{
			bodyRenderer.color = controller.Tan;
			armRenderer.color = controller.Tan;
		}
		else if (skinTone == 2)
		{
			bodyRenderer.color = controller.Brown;
			armRenderer.color = controller.Brown;
		}
		if (hairColor == 0)
		{
			hairRenderer.color = controller.hairRed;
		}
		else if (hairColor == 1)
		{
			hairRenderer.color = controller.hairBlack;
		}
		else if (hairColor == 2)
		{
			hairRenderer.color = controller.hairBrown;
		}
		else if (hairColor == 3)
		{
			hairRenderer.color = controller.hairBlonde;
		}
		else if (hairColor == 4)
		{
			hairRenderer.color = controller.hairGrey;
		}
		if (moveNPCS.isMoving)
		{
			Sprite[] array = controller.eyeList[eyeColor];
			Sprite[] array2 = controller.shirtList[favoriteColor];
			Sprite[] array3 = controller.hairList[hairStyle];
			Sprite[] array4 = controller.accesoryList[accessory];
			if (direction == 1)
			{
				int num = (int)time;
				GetComponent<Transform>().localScale = new Vector3(1f, 1f, 1f);
				bodyRenderer.sprite = controller.bodyFrames[num + 4];
				eyeRenderer.sprite = array[num + 4];
				hairRenderer.sprite = array3[num + 4];
				shirtRenderer.sprite = array2[num + 4];
				pantRenderer.sprite = controller.pantFrames[num + 4];
				armRenderer.sprite = controller.armFrames[num + 4];
				accesoryRenderer.sprite = array4[num + 4];
			}
			else if (direction == 3)
			{
				int num2 = (int)time;
				GetComponent<Transform>().localScale = new Vector3(1f, 1f, 1f);
				bodyRenderer.sprite = controller.bodyFrames[num2];
				eyeRenderer.sprite = array[num2];
				hairRenderer.sprite = array3[num2];
				shirtRenderer.sprite = array2[num2];
				pantRenderer.sprite = controller.pantFrames[num2];
				armRenderer.sprite = controller.armFrames[num2];
				accesoryRenderer.sprite = array4[num2];
			}
			else if (direction == 2)
			{
				int num3 = (int)time;
				GetComponent<Transform>().localScale = new Vector3(1f, 1f, 1f);
				bodyRenderer.sprite = controller.bodyFrames[num3 + 8];
				eyeRenderer.sprite = array[num3 + 8];
				hairRenderer.sprite = array3[num3 + 8];
				shirtRenderer.sprite = array2[num3 + 8];
				pantRenderer.sprite = controller.pantFrames[num3 + 8];
				armRenderer.sprite = controller.armFrames[num3 + 8];
				accesoryRenderer.sprite = array4[num3 + 8];
			}
			else if (direction == 4)
			{
				int num4 = (int)time;
				GetComponent<Transform>().localScale = new Vector3(-1f, 1f, 1f);
				bodyRenderer.sprite = controller.bodyFrames[num4 + 8];
				eyeRenderer.sprite = array[num4 + 8];
				hairRenderer.sprite = array3[num4 + 8];
				shirtRenderer.sprite = array2[num4 + 8];
				pantRenderer.sprite = controller.pantFrames[num4 + 8];
				armRenderer.sprite = controller.armFrames[num4 + 8];
				accesoryRenderer.sprite = array4[num4 + 8];
			}
		}
		else
		{
			time = 0f;
			Sprite[] array5 = controller.eyeList[eyeColor];
			Sprite[] array6 = controller.shirtList[favoriteColor];
			Sprite[] array7 = controller.hairList[hairStyle];
			Sprite[] array8 = controller.accesoryList[accessory];
			if (direction == 1)
			{
				GetComponent<Transform>().localScale = new Vector3(1f, 1f, 1f);
				bodyRenderer.sprite = controller.bodyFrames[4];
				eyeRenderer.sprite = array5[4];
				hairRenderer.sprite = array7[4];
				shirtRenderer.sprite = array6[4];
				pantRenderer.sprite = controller.pantFrames[4];
				armRenderer.sprite = controller.armFrames[4];
				accesoryRenderer.sprite = array8[4];
			}
			else if (direction == 3)
			{
				GetComponent<Transform>().localScale = new Vector3(1f, 1f, 1f);
				bodyRenderer.sprite = controller.bodyFrames[0];
				eyeRenderer.sprite = array5[0];
				hairRenderer.sprite = array7[0];
				shirtRenderer.sprite = array6[0];
				pantRenderer.sprite = controller.pantFrames[0];
				armRenderer.sprite = controller.armFrames[0];
				accesoryRenderer.sprite = array8[0];
			}
			else if (direction == 2)
			{
				GetComponent<Transform>().localScale = new Vector3(1f, 1f, 1f);
				bodyRenderer.sprite = controller.bodyFrames[8];
				eyeRenderer.sprite = array5[8];
				hairRenderer.sprite = array7[8];
				shirtRenderer.sprite = array6[8];
				pantRenderer.sprite = controller.pantFrames[8];
				armRenderer.sprite = controller.armFrames[8];
				accesoryRenderer.sprite = array8[8];
			}
			else if (direction == 4)
			{
				_ = time;
				GetComponent<Transform>().localScale = new Vector3(-1f, 1f, 1f);
				bodyRenderer.sprite = controller.bodyFrames[8];
				eyeRenderer.sprite = array5[8];
				hairRenderer.sprite = array7[8];
				shirtRenderer.sprite = array6[8];
				pantRenderer.sprite = controller.pantFrames[8];
				armRenderer.sprite = controller.armFrames[8];
				accesoryRenderer.sprite = array8[8];
			}
		}
	}
}
