using UnityEngine;

public class Audio_Reverb : MonoBehaviour
{
	private AudioReverbZone reverb;

	private float timeAnimationDistance;

	private float distanceMinWas;

	private float distanceMaxWas;

	private float distanceMinNeed;

	private float distanceMaxNeed;

	private float distanceMinOriginal;

	private float distanceMaxOriginal;

	[SerializeField]
	private float speedDistance;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void DistanceLerpActivation(bool x)
	{
	}
}
