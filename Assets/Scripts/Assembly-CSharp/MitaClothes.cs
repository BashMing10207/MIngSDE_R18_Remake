using System.Collections.Generic;
using MagicaCloth;
using UnityEngine;
using UnityEngine.Events;

public class MitaClothes : MonoBehaviour
{
	public SkinnedMeshRenderer rendAttribute;

	public SkinnedMeshRenderer rendBody;

	public SkinnedMeshRenderer rendPantyhose;

	public SkinnedMeshRenderer rendShoes;

	public SkinnedMeshRenderer rendSkirt;

	public SkinnedMeshRenderer rendSweater;

	public SkinnedMeshRenderer rendHead;

	public SkinnedMeshRenderer rendHairs;

	public ColliderComponent[] collidersMagic;

	public bool isMadMita;

	public bool dontDestroyStart;

	[SerializeField]
	private Dialogue_3DText.Dialogue3DTheme mita;

	[SerializeField]
	private UnityEvent eventReady;

	[SerializeField]
	[Header("Кепка")]
	private GameObject gloves;

	[HideInInspector]
	public Transform[] bones;

	[HideInInspector]
	public List<GameObject> newObjects;

	[HideInInspector]
	private Transform[] saveOldBones;

	private void Start()
	{
	}

	public void ReCloth()
	{
	}

	private void SetMaterials(SkinnedMeshRenderer _renderer, Material[] _materials, Texture2D[] _textures)
	{
	}
}
