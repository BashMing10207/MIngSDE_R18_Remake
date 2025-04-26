using System.Collections.Generic;
using MagicaCloth;
using UnityEngine;

public class Player_Ring : MonoBehaviour
{
	public GameObject ring;

	private int timeFace;

	[Header("Мешки под глазами")]
	[SerializeField]
	private Texture2D faceTime0;

	[SerializeField]
	private Texture2D faceTime1;

	[SerializeField]
	private Texture2D faceTime2;

	private int typeScar;

	[SerializeField]
	[Header("Рана")]
	private Texture2D textureNormalArms;

	[SerializeField]
	private Texture2D textureScarArms;

	[SerializeField]
	private Texture2D textureScarLongArms;

	[SerializeField]
	private Renderer arms;

	private List<Transform> transformsLimitTie;

	[Header("Галстук")]
	[SerializeField]
	private MagicaBoneCloth tieCloth;

	private Color colorLineSave;

	[SerializeField]
	[Header("Модель игрока")]
	private SkinnedMeshRenderer head;

	[SerializeField]
	private SkinnedMeshRenderer meshHairsMirror;

	[SerializeField]
	private SkinnedMeshRenderer meshArms;

	[SerializeField]
	private SkinnedMeshRenderer meshClothes;

	[SerializeField]
	private Mesh sharedMeshClothes;

	[SerializeField]
	private Material[] materialsClothes;

	[SerializeField]
	private Mesh sharedMeshArms;

	[SerializeField]
	private Material[] materialsArms;

	[Header("Пижама")]
	[SerializeField]
	private Mesh meshClothesPyjama;

	[SerializeField]
	private Material[] materialsClothesPyjama;

	[SerializeField]
	private Mesh meshArmsPyjama;

	[SerializeField]
	private Material[] materialsArmsPyjama;

	[Header("Праздники и события")]
	[SerializeField]
	private Player_PersonIvent[] ivent;

	private bool hideWasRing;

	private void Start()
	{
	}

	private void IventEvent()
	{
	}

	private void LateUpdate()
	{
	}

	public void AddLimitTie(Transform _target)
	{
	}

	public void RemoveLimitTie(Transform _target)
	{
	}

	public void FaceTime(int x)
	{
	}

	public void Scar(int _typeScar)
	{
	}

	public void Pyjama(bool x)
	{
	}

	public void PlayerShowShadow(bool x)
	{
	}

	public void HidePlayer(bool x)
	{
	}
}
