using UnityEngine;
using UnityEngine.Events;

public class MakeManeken_Interactive : MonoBehaviour
{
	public bool active;

	[SerializeField]
	private Renderer[] rend;

	[SerializeField]
	private bool tape;

	[SerializeField]
	private float intensity;

	[SerializeField]
	private UnityEvent eventClick;

	private MakeManeken_Main main;

	private float colorEmission;

	private bool mouseCast;

	private Color colorWas;

	private float timeAnimationHint;

	private AnimationCurve animationHint;

	private bool hint;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Click()
	{
	}

	public void Hint(bool x)
	{
	}
}
