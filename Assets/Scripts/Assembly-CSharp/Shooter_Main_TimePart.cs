using System;
using UnityEngine;

[Serializable]
public class Shooter_Main_TimePart
{
	[Range(0f, 3f)]
	public int typeEnemy;

	[Range(0f, 30f)]
	public float nextTime;
}
