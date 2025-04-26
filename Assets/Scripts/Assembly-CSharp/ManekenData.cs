using System;
using UnityEngine;

[Serializable]
public class ManekenData
{
	public bool canReset;

	public bool restartActive;

	public GameObject maneken;

	public Vector3[] positionStart;

	public float[] rotationStart;

	public Trigger_DistanceCircle restartCircle;

	public Trigger_DistanceCircle activeCircle;
}
