using UnityEngine;
using UnityEngine.Events;

public class Tamagotchi_MiniGame : MonoBehaviour
{
	public UnityEvent eventRestartGame;

	public UnityEvent eventStopGame;

	public Vector3 positionCamera;

	public Vector3 rotationCamera;

	public float size;

	public bool orthographic;

	public bool dontExit;

	private Camera cmr;

	private void Update()
	{
	}

	public void StartGame(Transform _camera)
	{
	}

	public void StopGame()
	{
	}

	public void SetLerpCameraSize(float _size)
	{
	}

	public void SetLerpCameraPosition(Vector3 _position)
	{
	}
}
