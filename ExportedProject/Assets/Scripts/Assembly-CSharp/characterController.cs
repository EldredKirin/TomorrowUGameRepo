using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
	public float moveSpeed = 5f;

	public Rigidbody2D rb;

	private Vector2 movement;

	public bool canSprint = true;

	public int direction = 3;

	private Animator animator;

	[SerializeField]
	private PlayerStats playerStats;

	[SerializeField]
	private GameObject player;

	private bool isMoving;

	private float animationTime = 4f;

	public float time;

	public Color Peach = new Color(1f, 1f, 1f, 1f);

	public Color Tan = new Color(0.8f, 0.72f, 0.51f, 1f);

	public Color Brown = new Color(0.51f, 0.43f, 0.34f);

	public Color hairRed = new Color(0.8867924f, 0.3765489f, 0.1455678f, 1f);

	public Color hairBlack = new Color(0.22f, 0.1792453f, 0.185f, 1f);

	public Color hairBrown = new Color(43f / 106f, 0.2486829f, 0.1775721f, 1f);

	public Color hairBlonde = new Color(1f, 0.9789482f, 0.4849057f, 1f);

	public Color hairGrey = new Color(0.6981132f, 0.6981132f, 0.6981132f, 1f);

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
	private Sprite[] redShirt;

	[SerializeField]
	private Sprite[] orangeShirt;

	[SerializeField]
	private Sprite[] yellowShirt;

	[SerializeField]
	private Sprite[] greenShirt;

	[SerializeField]
	private Sprite[] blueShirt;

	[SerializeField]
	private Sprite[] purpleShirt;

	[SerializeField]
	private Sprite[] blackShirt;

	[SerializeField]
	private Sprite[] brownShirt;

	[SerializeField]
	private Sprite[] whiteShirt;

	[SerializeField]
	public Sprite[] bodyFrames;

	[SerializeField]
	private Sprite[] sweptHair;

	[SerializeField]
	private Sprite[] buzzedHair;

	[SerializeField]
	private Sprite[] fluffyHair;

	[SerializeField]
	private Sprite[] mulletHair;

	[SerializeField]
	private Sprite[] brownEyes;

	[SerializeField]
	private Sprite[] blueEyes;

	[SerializeField]
	private Sprite[] greenEyes;

	[SerializeField]
	private Sprite[] hazelEyes;

	[SerializeField]
	private Sprite[] greyEyes;

	[SerializeField]
	public Sprite[] pantFrames;

	[SerializeField]
	public Sprite[] armFrames;

	[SerializeField]
	private Sprite[] noneAcc;

	[SerializeField]
	private Sprite[] glassesAcc;

	[SerializeField]
	public List<Sprite[]> shirtList = new List<Sprite[]>();

	[SerializeField]
	public List<Sprite[]> eyeList = new List<Sprite[]>();

	[SerializeField]
	public List<Sprite[]> hairList = new List<Sprite[]>();

	[SerializeField]
	public List<Sprite[]> accesoryList = new List<Sprite[]>();

	private void Start()
	{
		//ADDED CODE, MAYBE REMOVE LATER
		shirtList.Clear();
		eyeList.Clear();
		hairList.Clear();
		accesoryList.Clear();

		animator = GetComponent<Animator>();
		shirtList.Add(redShirt);
		shirtList.Add(orangeShirt);
		shirtList.Add(yellowShirt);
		shirtList.Add(greenShirt);
		shirtList.Add(blueShirt);
		shirtList.Add(purpleShirt);
		shirtList.Add(blackShirt);
		shirtList.Add(brownShirt);
		shirtList.Add(whiteShirt);
		eyeList.Add(brownEyes);
		eyeList.Add(blueEyes);
		eyeList.Add(greenEyes);
		eyeList.Add(hazelEyes);
		eyeList.Add(greyEyes);
		hairList.Add(sweptHair);
		hairList.Add(buzzedHair);
		hairList.Add(fluffyHair);
		hairList.Add(mulletHair);
		accesoryList.Add(noneAcc);
		accesoryList.Add(glassesAcc);
	}
	
	private void Update()
	{
		if (Input.GetKey(KeyCode.LeftShift) && canSprint)
		{
			moveSpeed = 10f;
			animationTime = 7f;
		}
		else
		{
			moveSpeed = 7f;
			animationTime = 4f;
		}
		movement.x = Input.GetAxis("Horizontal");
		movement.y = Input.GetAxis("Vertical");
		if (Input.GetAxis("Horizontal") > 0f)
		{
			direction = 2;
		}
		else if (Input.GetAxis("Horizontal") < 0f)
		{
			direction = 4;
		}
		if (Input.GetAxis("Vertical") > 0f && Input.GetAxis("Horizontal") == 0f)
		{
			direction = 1;
		}
		else if (Input.GetAxis("Vertical") < 0f && Input.GetAxis("Horizontal") == 0f)
		{
			direction = 3;
		}
		if (playerStats.skinTone == 0)
		{
			bodyRenderer.color = Peach;
			armRenderer.color = Peach;
		}
		else if (playerStats.skinTone == 1)
		{
			bodyRenderer.color = Tan;
			armRenderer.color = Tan;
		}
		else if (playerStats.skinTone == 2)
		{
			bodyRenderer.color = Brown;
			armRenderer.color = Brown;
		}
		if (playerStats.hairColor == 0)
		{
			hairRenderer.color = hairRed;
		}
		else if (playerStats.hairColor == 1)
		{
			hairRenderer.color = hairBlack;
		}
		else if (playerStats.hairColor == 2)
		{
			hairRenderer.color = hairBrown;
		}
		else if (playerStats.hairColor == 3)
		{
			hairRenderer.color = hairBlonde;
		}
		else if (playerStats.hairColor == 4)
		{
			hairRenderer.color = hairGrey;
		}
		time += animationTime * Time.deltaTime;
		if (time >= 4f)
		{
			time = 0f;
		}
		if (movement.x != 0f || movement.y != 0f)
		{
			isMoving = true;
		}
		else
		{
			isMoving = false;
		}
		if (isMoving)
		{
			Sprite[] array = eyeList[playerStats.eyeColor];
			Sprite[] array2 = shirtList[playerStats.favColor];
			Sprite[] array3 = hairList[playerStats.hairStyle];
			Sprite[] array4 = accesoryList[playerStats.accessory];
			if (direction == 1)
			{
				int num = (int)time;
				player.transform.localScale = new Vector3(1f, 1f, 1f);
				bodyRenderer.sprite = bodyFrames[num + 4];
				eyeRenderer.sprite = array[num + 4];
				hairRenderer.sprite = array3[num + 4];
				shirtRenderer.sprite = array2[num + 4];
				pantRenderer.sprite = pantFrames[num + 4];
				armRenderer.sprite = armFrames[num + 4];
				accesoryRenderer.sprite = array4[num + 4];
			}
			else if (direction == 3)
			{
				int num2 = (int)time;
				player.transform.localScale = new Vector3(1f, 1f, 1f);
				bodyRenderer.sprite = bodyFrames[num2];
				eyeRenderer.sprite = array[num2];
				hairRenderer.sprite = array3[num2];
				shirtRenderer.sprite = array2[num2];
				pantRenderer.sprite = pantFrames[num2];
				armRenderer.sprite = armFrames[num2];
				accesoryRenderer.sprite = array4[num2];
			}
			else if (direction == 2)
			{
				int num3 = (int)time;
				player.transform.localScale = new Vector3(1f, 1f, 1f);
				bodyRenderer.sprite = bodyFrames[num3 + 8];
				eyeRenderer.sprite = array[num3 + 8];
				hairRenderer.sprite = array3[num3 + 8];
				shirtRenderer.sprite = array2[num3 + 8];
				pantRenderer.sprite = pantFrames[num3 + 8];
				armRenderer.sprite = armFrames[num3 + 8];
				accesoryRenderer.sprite = array4[num3 + 8];
			}
			else if (direction == 4)
			{
				int num4 = (int)time;
				player.transform.localScale = new Vector3(-1f, 1f, 1f);
				bodyRenderer.sprite = bodyFrames[num4 + 8];
				eyeRenderer.sprite = array[num4 + 8];
				hairRenderer.sprite = array3[num4 + 8];
				shirtRenderer.sprite = array2[num4 + 8];
				pantRenderer.sprite = pantFrames[num4 + 8];
				armRenderer.sprite = armFrames[num4 + 8];
				accesoryRenderer.sprite = array4[num4 + 8];
			}
		}
		else
		{
			time = 0f;
			Sprite[] array5 = eyeList[playerStats.eyeColor];
			Sprite[] array6 = shirtList[playerStats.favColor];
			Sprite[] array7 = hairList[playerStats.hairStyle];
			Sprite[] array8 = accesoryList[playerStats.accessory];
			if (direction == 1)
			{
				player.transform.localScale = new Vector3(1f, 1f, 1f);
				bodyRenderer.sprite = bodyFrames[4];
				eyeRenderer.sprite = array5[4];
				hairRenderer.sprite = array7[4];
				shirtRenderer.sprite = array6[4];
				pantRenderer.sprite = pantFrames[4];
				armRenderer.sprite = armFrames[4];
				accesoryRenderer.sprite = array8[4];
			}
			else if (direction == 3)
			{
				player.transform.localScale = new Vector3(1f, 1f, 1f);
				bodyRenderer.sprite = bodyFrames[0];
				eyeRenderer.sprite = array5[0];
				hairRenderer.sprite = array7[0];
				shirtRenderer.sprite = array6[0];
				pantRenderer.sprite = pantFrames[0];
				armRenderer.sprite = armFrames[0];
				accesoryRenderer.sprite = array8[0];
			}
			else if (direction == 2)
			{
				player.transform.localScale = new Vector3(1f, 1f, 1f);
				bodyRenderer.sprite = bodyFrames[8];
				eyeRenderer.sprite = array5[8];
				hairRenderer.sprite = array7[8];
				shirtRenderer.sprite = array6[8];
				pantRenderer.sprite = pantFrames[8];
				armRenderer.sprite = armFrames[8];
				accesoryRenderer.sprite = array8[8];
			}
			else if (direction == 4)
			{
				_ = time;
				player.transform.localScale = new Vector3(-1f, 1f, 1f);
				bodyRenderer.sprite = bodyFrames[8];
				eyeRenderer.sprite = array5[8];
				hairRenderer.sprite = array7[8];
				shirtRenderer.sprite = array6[8];
				pantRenderer.sprite = pantFrames[8];
				armRenderer.sprite = armFrames[8];
				accesoryRenderer.sprite = array8[8];
			}
		}
	}
		
	private void FixedUpdate()
	{
		rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
	}
}
