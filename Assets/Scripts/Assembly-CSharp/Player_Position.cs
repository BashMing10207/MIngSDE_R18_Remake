using UnityEngine;

public class Player_Position : MonoBehaviour
{
	public AnimationCurve animationMove;

	public float speed;

	public bool finishActive;

	public bool rotation;

	public Transform playerTarget;

	private float timeAnimationMove;

	private bool play;

	private Vector3 positionPlayerWas;

	private Quaternion rotationPlayerWas;

	private void Update()
	{
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}
}
