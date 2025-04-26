using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuClothes_Case : MonoBehaviour
{
	public Image imgIcon;

	public GameObject change;

	public GameObject frame;

	[Header("Варианты цветов")]
	public GameObject exampleVariant;

	public RectTransform changeVariant;

	public List<GameObject> variants;

	[HideInInspector]
	public bool lockCloth;

	private MenuClothes main;

	private RectTransform caseUp;

	private RectTransform rect;

	private bool dressStart;

	private bool open;

	private int index;

	private bool dressNow;

	public void StartComponent(MenuClothes _main, RectTransform _caseUp, List<DataClothMitaVariant> _variants, Sprite _spriteCloth, int _index, bool _lock, bool _changeNow, string _nameMod)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Open(bool x)
	{
	}

	public void Dress(bool x)
	{
	}

	public void Click()
	{
	}

	public void ClickVariant(int _indexVariant)
	{
	}
}
