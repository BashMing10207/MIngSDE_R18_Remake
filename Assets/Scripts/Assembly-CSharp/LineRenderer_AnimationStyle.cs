using UnityEngine;

public class LineRenderer_AnimationStyle : MonoBehaviour
{
	private LineRenderer lr;

	private float timeAnimaitonNow;

	public bool play;

	public float speed;

	public float width;

	public AnimationCurve widthCurveValue;

	[Header("Audio")]
	public Transform audioT;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Active(bool x)
	{
	}

	private void OnEnable()
	{
	}
}
