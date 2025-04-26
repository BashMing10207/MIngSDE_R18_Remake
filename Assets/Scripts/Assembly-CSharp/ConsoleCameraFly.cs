using UnityEngine;

public class ConsoleCameraFly : MonoBehaviour
{
	private float speed;

	private bool pause;

	private float xRot;

	private float yRot;

	private float zRot;

	private int smoothRotation;

	private float speedIntensity;

	private float timeReFov;

	[HideInInspector]
	public float smoothMove;

	[HideInInspector]
	public Camera cameraSelf;

	[HideInInspector]
	public Camera camera2Self;

	private float fovNow;

	private Vector3 positionCameraNow;

	private GameController scrgc;

	public void StartComponent(Quaternion _rotation, bool _isPhotomode)
	{
	}

	private void Update()
	{
	}

	public void SetAngle(float _x)
	{
	}

	public void SetFOV(float _x)
	{
	}

	public void SetSmooth(float _x)
	{
	}
}
