using System.Collections.Generic;
using UnityEngine;

public class MenuClothes : MonoBehaviour
{
	[SerializeField]
	private GameObject resourceClothes;

	[SerializeField]
	private GameObject caseClothExample;

	[HideInInspector]
	public List<GameObject> casesCloth;

	[SerializeField]
	private AudioSource audioDress;

	[SerializeField]
	private AudioSource audioOpen;

	[SerializeField]
	private MitaClothes mitaClothes;

	[Header("Пользовательские текстуры")]
	public List<DataClothMitaVariant> texturesCustom;

	public List<bool> texturesWasLoadCustom;

	public List<string> texturesWasLoadCustomName;

	private int indexOpenNow;

	private RectTransform rectBack;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Click(int _index, bool _recloth)
	{
	}

	private void LoadUserTextures()
	{
	}

	private void ChangeUserCustom(int _indexVariant)
	{
	}

	private Texture2D LoadTexture(string _path)
	{
		return null;
	}
}
