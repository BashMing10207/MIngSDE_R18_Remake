using System;
using UnityEngine;

[Serializable]
public class TamagotchiGame_FindFurniture_Object
{
	public GameObject furniture;

	public UI_AlphaAnimation frameHint;

	public GameObject addoneObject;

	[HideInInspector]
	public float timeAddone;
}
