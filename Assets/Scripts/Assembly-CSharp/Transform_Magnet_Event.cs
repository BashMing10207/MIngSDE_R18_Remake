using UnityEngine;
using UnityEngine.Events;

[AddComponentMenu("Functions/Transform/Magnet Event")]
public class Transform_Magnet_Event : MonoBehaviour
{
	public bool Active;

	[Range(0f, 1f)]
	public float speed;

	public Transform transformObject;

	public Vector3 position;

	public bool rotationUse;

	public Vector3 rotation;

	[Range(0f, 1f)]
	public float useForce;

	public float MinimalDistanceEvent;

	public UnityEvent joinedEvent;

	[HideInInspector]
	public float spds;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	public void PassComponent(Transform_Magnet_Event obj)
	{
	}

	public void Activation(bool x)
	{
	}
}
