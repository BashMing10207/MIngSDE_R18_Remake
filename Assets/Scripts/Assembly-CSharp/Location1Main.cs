using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Location1Main : MonoBehaviour
{
	public Text textMyName;

	public Tamagotchi_Main tamagotchi;

	private bool canBuyTelevision;

	[Header("Купи телевизор")]
	public UnityEvent eventBuyTelevision;

	private float rotateCameraMita;

	[Header("Мита")]
	[SerializeField]
	private Transform mitaCameraPosition;

	private float timeAnimationMoveCamera;

	private float moveCameraWas;

	private float moveCameraNeed;

	[SerializeField]
	[Header("Камера")]
	private Transform cameraMitaT;

	[SerializeField]
	private AnimationCurve animationMoveCamera;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SaveName()
	{
	}

	public void CheckMoneyForTelevision()
	{
	}

	public void RotateLerpCameraMita(float x)
	{
	}

	public void RotateSharplyCameraMita(float x)
	{
	}

	public void MoveCamera(float x)
	{
	}

	public void MoveFastCamera(float x)
	{
	}
}
