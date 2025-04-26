using UnityEngine;

public class Light_ShadowIntensityDistancePlayer : MonoBehaviour
{
	public float distanceMin;

	public float distanceMax;

	public Light lightObject;

	public float shadowStrengthMax;

	public float shadowStrengthMin;

	private bool inside;

	private Transform playerT;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
