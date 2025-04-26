using UnityEngine;

public class LinePhysic : MonoBehaviour
{
	[SerializeField]
	private LinePhysic_Point[] points;

	[SerializeField]
	private AnimationCurve curveGravity;

	[SerializeField]
	private AnimationCurve curveLerp;

	[SerializeField]
	private float speeda;

	[SerializeField]
	private float speedb;

	[SerializeField]
	private float speedc;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
