using System;
using UnityEngine;

public class VirusAnimations : MonoBehaviour
{
	public Sprite[] animationSprites;

	public float animationTime = 1f;

	private SpriteRenderer spriteRenderer;

	private int animationFrame;

	public Action killed;

	public void Awake()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	private void Start()
	{
		InvokeRepeating("AnimateSprite", animationTime, animationTime);
	}

	private void AnimateSprite()
	{
		animationFrame++;
		if (animationFrame >= animationSprites.Length)
		{
			animationFrame = 0;
		}
		spriteRenderer.sprite = animationSprites[animationFrame];
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.layer == LayerMask.NameToLayer("Laser"))
		{
			killed();
			base.gameObject.SetActive(value: false);
		}
		else if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
		{
			GetComponentInParent<VirusGrid>().gameOver();
		}
	}
}
