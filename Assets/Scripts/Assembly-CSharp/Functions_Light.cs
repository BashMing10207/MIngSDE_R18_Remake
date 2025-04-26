using UnityEngine;

public class Functions_Light : MonoBehaviour
{
	public bool canShadow;

	public float noise;

	public float distanceDisable;

	public Color[] colorLightRandom;

	[Header("Region color")]
	public Color[] regionColorS;

	public float regionColorRadius;

	public bool regionColorGet;

	private Light lightComponent;

	private Transform cameraPosition;

	private Vector3 positionOriginal;

	private float intensityLight;

	public void Start()
	{
	}

	private void Update()
	{
	}

	public void ReShadow()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
