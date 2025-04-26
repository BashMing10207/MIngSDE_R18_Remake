using UnityEngine;

public class Menu_RunMouse : MonoBehaviour
{
	[SerializeField]
	private Camera UICamera;

	[SerializeField]
	private RectTransform RectParent;

	[SerializeField]
	private float distance;

	[SerializeField]
	private float distanceMove;

	[SerializeField]
	private float speedLerp;

	private Vector2 positionOriginal;

	private Vector2 positionMouse;

	private RectTransform rectSelf;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private Vector2 GetRectTransformScreenCenter(RectTransform _rect)
	{
		return default(Vector2);
	}
}
