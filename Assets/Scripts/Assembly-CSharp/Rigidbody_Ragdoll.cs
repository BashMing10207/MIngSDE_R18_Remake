using System.Collections.Generic;
using UnityEngine;

public class Rigidbody_Ragdoll : MonoBehaviour
{
	[Header("Части регдолла")]
	[SerializeField]
	private List<GameObject> partsPhysic;

	[SerializeField]
	private GameObject[] destroyObjectsBake;

	[SerializeField]
	private Component[] destroyComponentsBake;

	[Header("Лимит")]
	[SerializeField]
	private bool limitFloor;

	[SerializeField]
	private float limit;

	private void Update()
	{
	}

	public void Bake()
	{
	}

	public void Impulse(Vector3 _velocity)
	{
	}
}
