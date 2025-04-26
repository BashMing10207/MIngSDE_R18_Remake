using System;
using UnityEngine;

[Serializable]
public class Events_Objects_Reposition
{
	public Transform target;

	public Transform parent;

	[HideInInspector]
	public Vector3 position;

	[HideInInspector]
	public Quaternion rotation;
}
