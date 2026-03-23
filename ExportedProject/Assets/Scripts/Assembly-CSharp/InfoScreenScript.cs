using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoScreenScript : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> pages;

	private int currentPage;

	[SerializeField]
	private Text pageNumber;

	[SerializeField]
	private Text maxPageNumbers;

	private void Start()
	{
		maxPageNumbers.text = "/" + pages.Count;
	}

	private void Update()
	{
		for (int i = 0; i < pages.Count; i++)
		{
			if (i != currentPage)
			{
				pages[i].SetActive(value: false);
			}
			else
			{
				pages[i].SetActive(value: true);
			}
		}
	}

	public void upPage()
	{
		if (currentPage < pages.Count - 1)
		{
			currentPage++;
		}
		else
		{
			currentPage = 0;
		}
		pageNumber.text = (currentPage + 1).ToString() ?? "";
	}

	public void downPage()
	{
		if (currentPage != 0)
		{
			currentPage--;
		}
		else
		{
			currentPage = pages.Count - 1;
		}
		pageNumber.text = (currentPage + 1).ToString() ?? "";
	}
}
