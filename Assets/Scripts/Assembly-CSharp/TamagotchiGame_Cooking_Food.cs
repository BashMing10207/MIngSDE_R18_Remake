using System;
using UnityEngine;

[Serializable]
public class TamagotchiGame_Cooking_Food
{
	public Transform tObj;

	public UI_AlphaAnimation imageFrame;

	public float timeAnimation;

	public Vector3 positionStart;

	public Vector3 positionFinish;

	public Vector3 rotation;

	[Header("Резка")]
	public GameObject[] cutObject;

	[HideInInspector]
	public bool ready;
}
