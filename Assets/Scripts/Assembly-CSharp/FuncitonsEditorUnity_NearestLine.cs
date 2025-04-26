using System;
using System.Collections.Generic;
using UnityEngine;

public class FuncitonsEditorUnity_NearestLine : MonoBehaviour
{
	[Serializable]
	public struct Line
	{
		public Transform pointA;

		public Transform pointB;
	}

	public List<Line> lines;

	public Transform player;

	private Vector3 GetNearestPointOnLine(Vector3 a, Vector3 b, Vector3 point)
	{
		return default(Vector3);
	}

	private Vector3 FindNearestPoint()
	{
		return default(Vector3);
	}

	private void OnDrawGizmos()
	{
	}
}
