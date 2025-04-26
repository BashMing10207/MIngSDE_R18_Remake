using System;
using UnityEngine;

[Serializable]
public class CarSpace_Main_Enemy
{
	[HideInInspector]
	public float distanceMax;

	[HideInInspector]
	public int placeRoad;

	public CarSpace_Car carEnemy;

	[HideInInspector]
	public Vector3 positionOriginal;

	[HideInInspector]
	public Quaternion rotationOriginal;
}
