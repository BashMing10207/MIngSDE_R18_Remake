using UnityEngine;

public class SpriteRenderer_AlphaDistance : MonoBehaviour
{
	public float distanceMin;

	public float distanceMax;

	public AnimationCurve alphaDistance;

	private SpriteRenderer spr;

	private Transform player;

	private bool destroySmooth;

	private float distanceNow;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void DestroySmooth()
	{
	}
}
