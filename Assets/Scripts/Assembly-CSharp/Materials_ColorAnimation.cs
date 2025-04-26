using UnityEngine;

public class Materials_ColorAnimation : MonoBehaviour
{
	private Renderer rend;

	private float timeAnimation;

	private bool play;

	[SerializeField]
	private int[] indexMaterials;

	[SerializeField]
	private string nameColor;

	[ColorUsage(true, true)]
	[SerializeField]
	private Color colorA;

	[ColorUsage(true, true)]
	[SerializeField]
	private Color colorB;

	[SerializeField]
	private AnimationCurve animationColor;

	[SerializeField]
	private float animationSpeed;

	[SerializeField]
	private bool onStartPlay;

	[SerializeField]
	private bool loopAnimation;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ColorPlay(bool x)
	{
	}

	private void UpdateMaterials()
	{
	}
}
