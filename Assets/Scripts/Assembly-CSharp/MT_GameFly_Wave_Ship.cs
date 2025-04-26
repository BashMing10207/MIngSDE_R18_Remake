using System;
using UnityEngine;

[Serializable]
public class MT_GameFly_Wave_Ship
{
	public GameObject ship;

	[Range(-10f, 10f)]
	public float positionX;

	public float timeCreate;

	[Header("Особенности")]
	public bool animationMoveXActive;

	public AnimationCurve animationMoveX;

	public float moveDown;

	public bool limitDownActive;

	[Range(-1.5f, 6f)]
	public float limitDown;
}
