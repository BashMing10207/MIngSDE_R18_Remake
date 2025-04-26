using UnityEngine;

public class Light_LensDistanceLerp : MonoBehaviour
{
	[SerializeField]
	private float distanceMin;

	[SerializeField]
	private float distanceMax;

	[SerializeField]
	private Color colorMin;

	[SerializeField]
	private Color colorMax;

	[SerializeField]
	private AnimationCurve lerpDistance;

	private LensFlare lens;

	private Transform cameraT;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateColor()
	{
	}
}
