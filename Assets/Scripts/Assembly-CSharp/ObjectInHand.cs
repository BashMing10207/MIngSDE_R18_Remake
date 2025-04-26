using UnityEngine;

public class ObjectInHand : MonoBehaviour
{
	public ObjectInHandPosition[] positions;

	private PlayerMove scrpm;

	private Vector3 positionOrigin;

	private Quaternion rotationOrigin;

	private bool dropOrigin;

	private Transform mainParent;

	[Header("Информация")]
	public int indexPosition;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void DropOrigin()
	{
	}

	public void TakeInHand(int _index)
	{
	}
}
