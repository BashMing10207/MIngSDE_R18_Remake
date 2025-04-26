using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Location6_HintPathRing : MonoBehaviour
{
	[SerializeField]
	private GameObject objectExampleHint;

	[SerializeField]
	private Transform[] targetsMove;

	private float timeAnimaitonCurcle;

	[Header("Компас")]
	[SerializeField]
	private Transform pointerHinter;

	[SerializeField]
	private AnimationCurve animationBlinkAlpha;

	[SerializeField]
	private Image alphaCircle;

	private Transform player;

	private Transform cameraPlayer;

	private Transform ringPlayer;

	private bool play;

	private int indexTarget;

	[HideInInspector]
	public List<GameObject> objectsHint;

	private float timeInstance;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	public void Play(bool x)
	{
	}

	public void NextTrigger()
	{
	}

	public void Restart()
	{
	}
}
