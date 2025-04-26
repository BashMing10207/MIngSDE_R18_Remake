using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LinePhysic_Point
{
	public LineRenderer pointStart;

	public Transform pointFinish;

	public int countPoints;

	public List<Vector3> velocity;
}
