using UnityEngine;

public class VectorLineObjectMagnet : MonoBehaviour
{
	[Range(1f, 120f)]
	public int frameUpdate;

	private int fu;

	public float distance;

	public VectorLineObjectMagnetPoint[] lines;

	[Header("Objects")]
	public GameObject objectMove;

	public GameObject objectTarget;

	[Header("Settings")]
	public Vector3 generalPoint;

	public float generalDistance;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateObject()
	{
	}
}
