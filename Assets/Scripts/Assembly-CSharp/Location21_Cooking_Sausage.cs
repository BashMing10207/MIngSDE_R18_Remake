using System;
using UnityEngine;

[Serializable]
public class Location21_Cooking_Sausage
{
	public Transform sausage;

	public Transform targetPizza;

	[HideInInspector]
	public float timePos;

	[HideInInspector]
	public Vector3 posWas;

	[HideInInspector]
	public Quaternion rotWas;

	[HideInInspector]
	public float scaleWas;

	[HideInInspector]
	public bool needDeactive;
}
