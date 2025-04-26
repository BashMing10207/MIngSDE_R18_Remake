using System;
using UnityEngine;

[Serializable]
public class Location11_BlackRoom_Puzle
{
	public GameObject puzle;

	public Vector3 positionForFull;

	public bool addedTable;

	public Transform originalForGlue;

	[HideInInspector]
	public Vector3 posWas;

	[HideInInspector]
	public Quaternion rotWas;
}
