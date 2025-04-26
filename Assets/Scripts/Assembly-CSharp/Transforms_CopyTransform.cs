using NaughtyAttributes;
using UnityEngine;

public class Transforms_CopyTransform : MonoBehaviour
{
	[Label("Копирующие")]
	[SerializeField]
	private Transform[] copy;

	[SerializeField]
	[Label("Оригиналы")]
	private Transform[] paste;

	private void LateUpdate()
	{
	}
}
