using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

public class Trigger_DistanceCheck : MonoBehaviour
{
	[Label("Внутри")]
	[SerializeField]
	private UnityEvent eventInside;

	[SerializeField]
	[Label("Снаружи")]
	private UnityEvent eventOutside;

	[Header("Настройки")]
	[SerializeField]
	private Vector2 distance;

	[SerializeField]
	private Transform target;

	public void Check()
	{
	}
}
