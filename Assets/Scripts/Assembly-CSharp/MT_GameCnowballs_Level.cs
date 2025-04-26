using System;
using UnityEngine;

[Serializable]
public class MT_GameCnowballs_Level
{
	public Vector3[] balls;

	public GameObject obstacle;

	[Header("Результаты")]
	public Vector3 positionPlayer;

	public float rotationPlayer;

	public Vector3 positionMita;

	public float rotationMita;

	public Vector3 rotationCamera;

	public Vector3 positionCamera;

	public Vector3 positionSnowPlayer;

	public Vector3 positionSnowMita;

	public bool reverse;
}
