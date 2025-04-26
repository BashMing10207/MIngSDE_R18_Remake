using UnityEngine;

public class Location20_Bomb : MonoBehaviour
{
	public AnimationCurve animaitonFly;

	private float timeAnimationFly;

	public GameObject objectExplosion;

	private Transform killPlayer;

	private Vector3 positionStart;

	private Vector3 positionFinish;

	private Location20_Arena main;

	private AudioSource audioWind;

	public void StartComponent(Location20_Arena _main, Vector3 _positionStart, Vector3 _positionFinish, Transform _player)
	{
	}

	private void Update()
	{
	}

	private void Explosion()
	{
	}
}
