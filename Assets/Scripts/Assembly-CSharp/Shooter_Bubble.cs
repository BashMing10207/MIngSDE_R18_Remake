using UnityEngine;

public class Shooter_Bubble : MonoBehaviour
{
	private AudioSource audios;

	private float timeAnimation;

	[SerializeField]
	private AnimationCurve animationScale;

	[SerializeField]
	private GameObject particleSplash;

	[SerializeField]
	private Shooter_Player player;

	[SerializeField]
	private AudioClip[] soundsSplash;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Explode()
	{
	}
}
