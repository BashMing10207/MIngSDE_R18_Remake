using UnityEngine;

public class Player_Teleport : MonoBehaviour
{
	private PlayerMove scrpm;

	public Vector3 position;

	public bool positionAdd;

	[Header("Вращение")]
	public bool useRotation;

	public float rotation;

	public bool rotationAdd;

	[Header("Голова")]
	public bool useRotationHead;

	[Range(-89f, 89f)]
	public float rotationHead;

	[ContextMenu("Телепортировать")]
	public void Click()
	{
	}

	public void SoftClick()
	{
	}
}
