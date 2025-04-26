using UnityEngine;

public class GameObject_Create : MonoBehaviour
{
	public GameObject objectCreate;

	public GameObject targetPosition;

	[Space(7f)]
	public Vector3 positionTargetForward;

	public Vector3 rotationTargetForward;

	[Header("Settings")]
	public string findTargetPlayer;

	public float timeReCreate;

	private float timeReCreateNow;

	public GameObject objectCreateNow;

	public bool useObjectCreateFromNow;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void CreateObject()
	{
	}

	public void DestroyCreateObject()
	{
	}
}
