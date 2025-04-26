using UnityEngine;

public class Light_Distance : MonoBehaviour
{
	private float lightIntensity;

	[Header("Свет")]
	[SerializeField]
	private Light lightComponent;

	private Color lensColor;

	[Header("Свечение")]
	[SerializeField]
	private LensFlare lens;

	[SerializeField]
	[Header("Настройки")]
	private float distanceMin;

	[SerializeField]
	private float distanceMax;

	[SerializeField]
	private AnimationCurve lerpDistance;

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
