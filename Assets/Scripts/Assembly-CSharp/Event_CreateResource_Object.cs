using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Event_CreateResource_Object
{
	public Transform parent;

	public GameObject[] prefabCreate;

	[HideInInspector]
	public List<Vector3> positions;

	[HideInInspector]
	public List<Quaternion> rotations;

	[HideInInspector]
	public List<Vector3> scales;
}
