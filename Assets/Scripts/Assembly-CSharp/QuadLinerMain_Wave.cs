using System;
using UnityEngine;

[Serializable]
public class QuadLinerMain_Wave
{
	[HideInInspector]
	public GameObject caseWave;

	public float time;

	[Range(0f, 10f)]
	public int[] enemys;

	[Range(0f, 10f)]
	public int[] enemysShield;
}
