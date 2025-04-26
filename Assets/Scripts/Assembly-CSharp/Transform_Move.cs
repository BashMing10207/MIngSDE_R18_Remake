using UnityEngine;

public class Transform_Move : MonoBehaviour
{
	public enum TypeMove
	{
		Forward = 0,
		Right = 1,
		Up = 2,
		None = 3
	}

	public TypeMove typeMove;

	public Vector3 myMove;

	public float speed;

	public bool active;

	public bool SmoothUse;

	[Range(0f, 1f)]
	public float SmoothSpeed;

	private Vector3 speedMove;

	private float _spd;

	private void FixedUpdate()
	{
	}

	public void Activation(bool x)
	{
	}

	public void ActivationOn()
	{
	}
}
