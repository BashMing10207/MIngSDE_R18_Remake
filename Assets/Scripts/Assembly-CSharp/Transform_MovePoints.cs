using UnityEngine;
using UnityEngine.Events;

[AddComponentMenu("Functions/Transform/Transform move points")]
public class Transform_MovePoints : MonoBehaviour
{
	[SerializeField]
	private bool stop;

	[SerializeField]
	private Vector3[] points;

	[SerializeField]
	private float speed;

	[Header("Настройки")]
	[SerializeField]
	private bool loop;

	[SerializeField]
	private bool destroyAfter;

	[SerializeField]
	private UnityEvent eventFinishPoint;

	private int indexPoint;

	private void Update()
	{
	}

	private void Next()
	{
	}
}
