using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

public class Random_Position : MonoBehaviour
{
	[SerializeField]
	private List<TransformSimple> positions;

	[SerializeField]
	private bool onStart;

	[SerializeField]
	private bool destroyThisAfter;

	private void Start()
	{
	}

	[Button("Рандомная позиция", EButtonEnableMode.Always)]
	public void RandomPosition()
	{
	}
}
