using UnityEngine;

public class Transform_SimpleCopyPosition : MonoBehaviour
{
	[Header("Копирует позицию и вращение (LateUpdate)")]
	public Transform copyPosition;

	public string playerTransform;

	public Vector3 positionAdd;

	public Vector3 rotationAdd;

	[Header("Дополнение")]
	public Transform startParent;

	public float lerpSpeed;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}
}
